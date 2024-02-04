using Musify.Infra;
using System.ComponentModel.DataAnnotations;

namespace Musify.API.Models
{
    public class Like : IIdentifiable
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        public User? User { get; set; }

        [Required]
        public string EntityType { get; set; }

        [Required]
        public int EntityId { get; set; }
    }
}
