using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.MVVM.Models
{
    public class AlbumSong
    {
        public Guid albumId { get; set; }
        public Guid songId { get; set; }
    }
}