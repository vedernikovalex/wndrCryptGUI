using passwordManager.helpers;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace passwordManager
{
    /// <summary>
    /// The <see cref="Credential"/> class represents a credential entity with functionality for managing credentials.
    /// Also being used as JSON Credential object format.
    /// </summary>
    public class Credential
    {
        private string name = string.Empty;
        private byte[] password = Array.Empty<byte>();
        private string note = string.Empty;
        private string username = string.Empty;
        private static readonly string credsFilePath = "credentials.json";

        /// <summary>
        /// Gets or sets the name of the credential.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password of the credential.
        /// </summary>
        [JsonPropertyName("password")]
        public byte[] Password { get; set; } = Array.Empty<byte>();

        /// <summary>
        /// Gets or sets the note for the credential.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username associated with the credential.
        /// </summary>
        [JsonPropertyName("username")]
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Deserialization constructor.
        /// </summary>
        public Credential() 
        {
            Name = string.Empty;
            Password = Array.Empty<byte>();
            Note = string.Empty;
            Username = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Credential"/> class with the specified parameters.
        /// </summary>
        /// <param name="name">The name of the credential.</param>
        /// <param name="password">The password of the credential.</param>
        /// <param name="note">The note for the credential.</param>
        /// <param name="username">The username associated with the credential.</param>
        public Credential(string name, byte[] password, string note, string username)
        {
            Name = name;
            Password = password;
            Note = note;
            Username = username;
        }

        /// <summary>
        /// Retrieves a credential by its index from the credentials list.
        /// </summary>
        /// <param name="index">The index of the credential.</param>
        /// <returns>The credential at the specified index, or null if not found or index is out of range.</returns>
        public static Credential? GetCredential(int index, string username)
        {
            List<Credential> credentials = FileHelper.GetListFromFile<Credential>(credsFilePath);
            List<Credential> userCredentials = credentials.Where(cred => cred.Username == username).ToList();

            if (userCredentials == null || userCredentials.Count == 0)
            {
                Debug.WriteLine("No credentials found for the user.");
                return null;
            }

            if (index < 0 || index >= userCredentials.Count)
            {
                Debug.WriteLine("Index is out of range.");
                return null;
            }

            Credential credential = userCredentials[index];
            return credential;
        }

        /// <summary>
        /// Retrieves a list of credentials associated with a specified username.
        /// </summary>
        /// <param name="username">The username to filter credentials.</param>
        /// <returns>A list of credentials associated with the username.</returns>
        public static List<Credential> GetCredentialList(string username)
        {
            List<Credential> credentials = FileHelper.GetListFromFile<Credential>(credsFilePath);
            return credentials.Where(cred => cred.Username == username).ToList();
        }

        /// <summary>
        /// Adds a new credential to the credentials list.
        /// </summary>
        /// <param name="credential">The credential to add.</param>
        public static void AddNewCredential(Credential credential)
        {
            try
            {
                List<Credential> credentials = FileHelper.GetListFromFile<Credential>(credsFilePath);

                credentials.Add(credential);
                string strToAdd = JsonSerializer.Serialize(credentials);
                File.WriteAllText(credsFilePath, strToAdd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while adding credential\nSee debug console for more information", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"An error occurred while adding credential: {ex.Message}");
            }
        }

        /// <summary>
        /// Deletes a credential from the credentials list.
        /// </summary>
        /// <param name="index">The index of the credential to delete.</param>
        /// <param name="username">The username associated with the credential.</param>
        public static void DeleteCredential(int index, string username)
        {
            try
            {
                List<Credential> credentials = FileHelper.GetListFromFile<Credential>(credsFilePath);

                List<Credential> userCredentials = credentials.Where(cred => cred.Username == username).ToList();

                if (index < 0 || index >= userCredentials.Count)
                {
                    Debug.WriteLine("Index is out of range.");
                    return;
                }

                Credential credentialToDelete = userCredentials[index];
                credentials.Remove(credentialToDelete);

                string strToAdd = JsonSerializer.Serialize(credentials);
                File.WriteAllText(credsFilePath, strToAdd);

                Debug.WriteLine("Credential deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while deleting credential\nSee debug console for more information", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine($"An error occurred while deleting the credential: {ex.Message}");
            }
        }
    }
}
