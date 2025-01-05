using passwordManager.helpers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace passwordManager.userLogic
{
    /// <summary>
    /// The <see cref="User"/> class represents a user object with authentication and registration functionality.
    /// Also being used as JSON User object format.
    /// </summary>
    public class User
    {
        private string username = string.Empty;
        private byte[] password = Array.Empty<byte>();
        private byte[] salt = Array.Empty<byte>();
        private byte[] derivationSalt = Array.Empty<byte>();
        private static readonly string userFilePath = "users.json";
        private static readonly Regex passwordRules = new Regex(@"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{10,}$");

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        [JsonPropertyName("name")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the hashed password of the user.
        /// </summary>
        [JsonPropertyName("password")]
        public byte[] Password { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the salt used for password hashing.
        /// </summary>
        [JsonPropertyName("salt")]
        public byte[] Salt { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the salt used for key derivation.
        /// </summary>
        [JsonPropertyName("derivationSalt")]
        public byte[] DerivationSalt { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        public User() 
        {
            Username = string.Empty;
            Password = Array.Empty<byte>();
            Salt = Array.Empty<byte>();
            DerivationSalt = Array.Empty<byte>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class with the specified parameters.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The hashed password of the user.</param>
        /// <param name="salt">The salt used for password hashing.</param>
        /// <param name="derivationSalt">The salt used for key derivation.</param>
        public User(string username, byte[] password, byte[] salt, byte[] derivationSalt)
        {
            Username = username;
            Password = password;
            Salt = salt;
            DerivationSalt = derivationSalt;
        }

        /// <summary>
        /// Logs in a user with the specified username and password.
        /// </summary>
        /// <param name="username">The username of the user.</param>
        /// <param name="password">The password of the user.</param>
        /// <returns>The logged-in user if successful, otherwise null.</returns>
        public static User? Login(string username, string password)
        {
            List<User> users = FileHelper.GetListFromFile<User>(userFilePath);
            foreach (User user in users)
            {
                if (user.Username != username)
                {
                    return null;
                }
                byte[] salt = user.Salt;
                bool passwordsMatch = UserAuth.VerifyPassword(password, salt, user.Password);
                if (passwordsMatch)
                {
                    Globals.Key = Crypt.GetDerivedEncryptionKey(password, user.DerivationSalt);
                    return user;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Registers a new user with the specified username and password.
        /// </summary>
        /// <param name="username">The username of the new user.</param>
        /// <param name="password">The password of the new user.</param>
        /// <returns>The newly registered user.</returns>
        public static User Register(string username, string password)
        {
            List<User> userList = FileHelper.GetListFromFile<User>(userFilePath);

            if (UserExists(username))
            {
                throw new InvalidOperationException("User already exists.");
            }

            byte[] salt = UserAuth.GenerateSalt();
            byte[] derivationSalt = UserAuth.GenerateSalt();
            byte[] hashedPassword = UserAuth.HashPassword(password, salt);

            User newUser = new User(username, hashedPassword, salt, derivationSalt);

            Globals.Key = Crypt.GetDerivedEncryptionKey(password, derivationSalt);

            userList.Add(newUser);
            string strToAdd = JsonSerializer.Serialize(userList);
            File.WriteAllText(userFilePath, strToAdd);
            return newUser;
        }

        /// <summary>
        /// Checks if a user with the specified username exists.
        /// </summary>
        /// <param name="username">The username to check.</param>
        /// <returns>True if the user exists, otherwise false.</returns>
        public static bool UserExists(string username)
        {
            List<User>? users = FileHelper.GetListFromFile<User>(userFilePath);

            if (users != null)
            {
                foreach (User user in users)
                {
                    if (user.Username == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Checks if a password meets the defined rules for validity.
        /// </summary>
        /// <param name="password">The password to check.</param>
        /// <returns>True if the password is valid, otherwise false.</returns>
        public static bool CheckPasswordValidity(string password)
        {
            return passwordRules.IsMatch(password);
        }

        /// <summary>
        /// Returns the username of the user.
        /// </summary>
        /// <returns>The username of the user.</returns>
        public override string ToString()
        {
            return this.Username;
        }
    }
}
