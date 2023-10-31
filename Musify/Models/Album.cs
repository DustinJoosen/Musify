using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.Models
{
    public class Album : NotifyPropertyChanged
    {
        public int Id { get; set; }

        private string _title;
        public string Title
        {
            get => this._title;
            set  {
                this._title = value;
                RaisePropertyChanged(nameof(Title));
            }
        }

        private int _releaseYear;
        public int ReleaseYear
        {
            get => this._releaseYear;
            set => this._releaseYear = value;
        }

        private string _coverImage;
        public string CoverImage
        {
            get => this._coverImage;
            set => this._coverImage = value;
        }
    }
}