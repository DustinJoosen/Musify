using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Musify.API.Middleware;
using Musify.API.Services.Images;
using Musify.Infra.Dtos;

namespace Musify.API.Controllers
{
    [Route("api/[controller]")]
    [ApiKeyAuthorized(Permission = Infra.ApiKeyPermissions.Write)]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private IImageService _imageService;
        public ImageController(IImageService imageService)
        {
            this._imageService = imageService;
        }

        [HttpPost("Upload/{target}")]
        public async Task<IActionResult> UploadImage(IFormFile image, string target = "albums")
        {
            // Ensure the given formfile is valid.
            if (!this._imageService.IsFileValid(image, out string error))
                return BadRequest(error);

            // Determine location of the new file.
            var uniqueFileName = this._imageService.GenerateGUIDImageName(image.FileName);
            var filePath = Path.Combine("wwwroot", "images", target, uniqueFileName);

            // Save the new file.
            bool succeeded = await this._imageService.TryUpload(image, filePath);

            return Ok(new ImageResponseDto
            {
                FileName = uniqueFileName,
                Succeeded = succeeded
            });
        }

        [HttpDelete("Delete/{target}")]
        public async Task<IActionResult> DeleteImage(string target, string fileName)
        {
            var filePath = Path.Combine("wwwroot", "images", target, fileName);
            if (!this._imageService.FileExists(filePath))
                return NotFound("Could not find file");

            // Delete the file.
            bool succeeded = await this._imageService.TryDelete(filePath);

            return Ok(new ImageResponseDto
            {
                FileName = filePath,
                Succeeded = succeeded
            });
        }
    }
}
