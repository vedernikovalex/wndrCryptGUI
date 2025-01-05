using System;

namespace passwordManager.helpers
{
    /// <summary>
    /// The <see cref="Globals"/> class provides global variables and properties for password management.
    /// </summary>
    public static class Globals
    {
        /// <summary>
        /// The key used for encryption and decryption operations.
        /// </summary>
        public static byte[]? key;

        /// <summary>
        /// Gets or sets the encryption key.
        /// </summary>
        public static byte[]? Key { get; set; }
    }
}
