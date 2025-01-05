using System.Diagnostics;
using System.Text.Json;

namespace passwordManager.helpers
{
    /// <summary>
    /// The <see cref="FileHelper"/> class provides helper methods for file operations.
    /// </summary>
    public static class FileHelper
    {
        /// <summary>
        /// Reads data from a file and deserializes it into a list of specified generic type.
        /// </summary>
        /// <typeparam name="T">The generic type of objects in the list.</typeparam>
        /// <param name="filePath">The path of the file to read from.</param>
        /// <returns>A list of deserialized objects from the file, or an empty list if the file doesn't exist or is empty.</returns>
        public static List<T> GetListFromFile<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string existingData = File.ReadAllText(filePath);
                    return !string.IsNullOrEmpty(existingData)
                        ? JsonSerializer.Deserialize<List<T>>(existingData) ?? []
                        : [];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while reading credentials file\nSee debug console for more information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Debug.WriteLine($"An error occurred while reading credentials file: {ex.Message}");
                    return [];
                }
            }
            else
            {
                return [];
            }
        }
    }
}