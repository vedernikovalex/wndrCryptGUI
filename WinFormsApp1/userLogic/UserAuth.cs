using System.Security.Cryptography;

namespace passwordManager.userLogic
{
    /// <summary>
    /// Provides methods for generating salt, hashing passwords, and verifying passwords using cryptographic functions.
    /// </summary>
    public static class UserAuth
    {
        private const int Iterations = 10000; // Number of iterations for key derivation function
        private const int SaltSize = 16; // Size of salt in bytes
        private const int HashSize = 20; // Size of hashed password in bytes

        /// <summary>
        /// Generates a random salt.
        /// </summary>
        /// <returns> A byte array containing the generated salt. </returns>
        public static byte[] GenerateSalt()
        {
            byte[] salt = new byte[SaltSize]; // byte array for salt
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt); // Fill the byte array with random values
            }
            return salt;
        }

        /// <summary>
        /// Hashes the given password using the provided salt.
        /// </summary>
        /// <param name="password"> The password to hash. </param>
        /// <param name="salt"> The salt to use for hashing. </param>
        /// <returns> A byte array containing the hashed password. </returns>
        public static byte[] HashPassword(string password, byte[] salt)
        {
            using (Rfc2898DeriveBytes deriveBytes = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                return deriveBytes.GetBytes(HashSize); // Derivation PBKDF2 with SHA-256
            }
        }

        /// <summary>
        /// Verifies whether the provided password matches the hashed password using the given salt.
        /// </summary>
        /// <param name="password">The password to verify.</param>
        /// <param name="salt">The salt used for hashing the password.</param>
        /// <param name="hashedPassword">The hashed password to compare against.</param>
        /// <returns> 
        /// True if the password matches the hashed password
        /// Otherwise, false. 
        /// </returns>
        public static bool VerifyPassword(string password, byte[] salt, byte[] hashedPassword)
        {
            byte[] newHash = HashPassword(password, salt);
            return ConstantTimeComparison(newHash, hashedPassword);
        }

        /// <summary>
        /// Performs constant-time comparison of two byte arrays.
        /// </summary>
        /// <param name="a">The first byte array to compare.</param>
        /// <param name="b">The second byte array to compare.</param>
        /// <returns>True if the byte arrays are equal; otherwise, false.</returns>
        private static bool ConstantTimeComparison(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i]; // XOR
            }
            return result == 0; // If result is 0, arrays are equal; otherwise, they are not
        }
    }
}
