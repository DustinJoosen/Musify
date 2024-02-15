
namespace Musify.API.Services.Images
{
    public interface IImageService
    {
        /// <summary>
        /// Generates a full fileName
        /// </summary>
        /// <param name="fileName">The base filename</param>
        /// <returns>A newly generated filename, including a guid at the start</returns>
        public string GenerateGUIDImageName(string fileName);

        /// <summary>
        /// Checks wether a file is valid
        /// </summary>
        /// <param name="image">Image to be checked</param>
        /// <param name="error">Output errors</param>
        /// <returns>A boolean determining success</returns>
        public bool IsFileValid(IFormFile image, out string error);

        /// <summary>
        /// Tries to upload a file
        /// </summary>
        /// <param name="image">File to be uploaded</param>
        /// <param name="filePath">Filepath to upload file in</param>
        /// <returns>A boolean determining success</returns>
        public Task<bool> TryUpload(IFormFile image, string filePath);

        /// <summary>
        /// Tries to delete a file
        /// </summary>
        /// <param name="filePath">Filepath of the file to delete</param>
        /// <returns>A boolean determining success</returns>
        public Task<bool> TryDelete(string filePath);

        /// <summary>
        /// Checks wether a file already exists
        /// </summary>
        /// <param name="fileName">fileName of the file to be checked</param>
        /// <returns>Boolean determining wether a file exists or not</returns>
        public bool FileExists(string fileName);
    }
}