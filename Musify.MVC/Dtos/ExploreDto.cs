using System.ComponentModel.DataAnnotations;

namespace Musify.MVC.Dtos
{
    public enum SearchType
    {
        Songs,
        Albums,
        Artists,
        Playlists
    }

    public class ExploreDto
    {
        [Display(Name = "Search")]
        public string SearchText { get; set; }

        [Display(Name = "Search")]
        public SearchType SearchType { get; set; }

    }
}
