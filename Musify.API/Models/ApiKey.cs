using Musify.Infra;
using System.ComponentModel.DataAnnotations;

namespace Musify.API.Models
{
    public class ApiKey
    {
        [Key]
        [StringLength(50)]
        public string Key { get; set; }

        public int? UserId { get; set; }
        public User? User { get; set; }

        [Required]
        public ApiKeyPermissions Permissions { get; set; }

        public DateTime? ExpirationDate { get; set; }
        
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
