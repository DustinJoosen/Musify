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

        public bool FileExists(string fileName) =>
            File.Exists(fileName);

        public string GenerateGUIDImageName(string fileName)
        {
            string guid = Guid.NewGuid().ToString().Replace("-", string.Empty);
            return $"{guid}_{fileName}";
        }

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
