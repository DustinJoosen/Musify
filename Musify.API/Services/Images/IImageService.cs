
namespace Musify.API.Services.Images
{
    public interface IImageService
    {
        public string GenerateGUIDImageName(string fileName);
        public bool IsFileValid(IFormFile image, out string error);
        public Task<bool> TryUpload(IFormFile image, string filePath);
        public Task<bool> TryDelete(string filePath);
        public bool FileExists(string fileName);
    }
}