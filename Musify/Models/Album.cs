using Musify.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.Models
{
    public class Album : NotifyPropertyChanged
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        private string _title;
        public string Title
        {
            get => this._title;
            set
            {
                this._title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private int _releaseYear;
        public int ReleaseYear
        {
            get => this._releaseYear;
            set
            {
                this._releaseYear = value;
                RaisePropertyChanged(nameof(ReleaseYear));
            }
        }

        private string _coverImage;
        public string CoverImage
        {
            get => this._coverImage;
            set => this._coverImage = value;
        }

        /*
         * Here start a few easy properties, that need more then 1 property.
         * Like when you need a combination. This place is unfortunaletly the best place.
         */

        public string Artist => "mixed";    // Rework this when the numbers and albums are linked.
        public string FullImagePath => $"../../../Lib/Uploads/{this.CoverImage}";
        public string DetailPageUnderline => $"{this.Artist} | {this.ReleaseYear}";
    }
}
