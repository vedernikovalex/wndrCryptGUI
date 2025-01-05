using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace passwordManager
{
    /// <summary>
    /// The <see cref="Crypt"/> class provides methods for encryption and decryption using AES algorithm and derived key.
    /// </summary>
    public static class Crypt
    {
        /// <summary>
        /// Generates a derived encryption key based on the provided password and salt.
        /// </summary>
        /// <param name="password">The password used for key derivation.</param>
        /// <param name="salt">The salt value used for key derivation.</param>
        /// <returns>The derived encryption key.</returns>
        public static byte[] GetDerivedEncryptionKey(string password, byte[] salt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(32);
            }
        }

        /// <summary>
        /// Encrypts a string using AES algorithm.
        /// </summary>
        /// <param name="password">The text to be encrypted.</param>
        /// <param name="key">The encryption key.</param>
        /// <param name="salt">The salt value.</param>
        /// <returns>The encrypted bytes.</returns>
        public static byte[]? Encrypt(string password, byte[] key, string salt)
        {
            byte[] encryptedPassword = Encoding.Unicode.GetBytes(password);
            byte[] saltBytes = Encoding.Unicode.GetBytes(salt);
            // Advanced Encryption Standard 
            using (Aes encryptor = Aes.Create())
            {
                try
                {
                    string keyString = Convert.ToBase64String(key);
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(keyString, saltBytes);
                    encryptor.Key = pdb.GetBytes(32);

                    // Vector
                    // used to ensure that each encryption operation produces a unique ciphertext
                    // even if the same plaintext is encrypted multiple times with the same key.
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(encryptedPassword, 0, encryptedPassword.Length);
                            cs.Close();
                        }
                        return ms.ToArray();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error occured while encrypting\nSee debug console for more information", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine($"Error occured while encrypting: {ex.Message}");
                    return null;
                }
            }
        }

        /// <summary>
        /// Decrypts a byte array using AES algorithm.
        /// </summary>
        /// <param name="encryptedPassword">The encrypted bytes.</param>
        /// <param name="key">The encryption key.</param>
        /// <param name="salt">The salt value.</param>
        /// <returns>The decrypted string.</returns>
        public static string? Decrypt(byte[] encryptedPassword, byte[] key, string salt)
        {
            byte[] saltBytes = Encoding.Unicode.GetBytes(salt);
            using (Aes encryptor = Aes.Create())
            {
                try
                {
                    string keyString = Convert.ToBase64String(key);
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(keyString, saltBytes);
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream(encryptedPassword))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (StreamReader reader = new StreamReader(cs))
                            {
                                return reader.ReadToEnd().Replace("\0", "");
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error occured while decrypting\nSee debug console for more information", "Unknown error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine($"Error occured while decrypting: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
