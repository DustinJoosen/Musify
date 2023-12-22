using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Models.Interfaces
{
    public interface IUserLike
    {
        public int UserId { get; set; }
        public User User { get; set; }
    }
}