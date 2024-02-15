using Musify.API.Data;

namespace Musify.API.Services.Images
{
    public class ImageService : IImageService
    {
        private ApplicationDbContext _context;
        public ImageService(ApplicationDbContext context)
        {
            this._context = context;
        }

        /// <summary>
        /// Checks wether a file already exists
        /// </summary>
        /// <param name="fileName">fileName of the file to be checked</param>
        /// <returns>Boolean determining wether a file exists or not</returns>
        public bool FileExists(string fileName) =>
            File.Exists(fileName);

        /// <summary>
        /// Generates a full fileName
        /// </summary>
        /// <param name="fileName">The base filename</param>
        /// <returns>A newly generated filename, including a guid at the start</returns>
        public string GenerateGUIDImageName(string fileName)
        {
            string guid = Guid.NewGuid().ToString().Replace("-", string.Empty);
            return $"{guid}_{fileName}";
        }

        /// <summary>
        /// Checks wether a file is valid
        /// </summary>
        /// <param name="image">Image to be checked</param>
        /// <param name="error">Output errors</param>
        /// <returns>A boolean determining success</returns>
        public bool IsFileValid(IFormFile image, out string error)
        {
            // Check if file is valid.
            if (image == null || image.Length == 0)
            {
                error = "Invalid or empty file";
                return false;
            }

            // Check if extension is valid
            string[] allowedExtensions = [".jpg", ".jpeg", ".png"];
            if (!allowedExtensions.Contains(Path.GetExtension(image.FileName).ToLowerInvariant()))
            {
                error = "Invalid file format. Supported formats: jpg, jpeg, png";
                return false;
            }

            error = string.Empty;
            return true;
        }

        /// <summary>
        /// Tries to delete a file
        /// </summary>
        /// <param name="filePath">Filepath of the file to delete</param>
        /// <returns>A boolean determining success</returns>
        public async Task<bool> TryDelete(string filePath)
        {
            try
            {
                File.Delete(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tries to upload a file
        /// </summary>
        /// <param name="image">File to be uploaded</param>
        /// <param name="filePath">Filepath to upload file in</param>
        /// <returns>A boolean determining success</returns>
        public async Task<bool> TryUpload(IFormFile image, string filePath)
        {
            try
            {
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
