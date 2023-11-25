using Musify.MVVM.Models;
using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels.Albums
{
    public class AlbumSearchFilterViewModel : Album, IDataErrorInfo
    {

        public Action Callback { get; set; }

        private static int _minSize = 1900;
        public int MinSize
        {
            get => _minSize;
            set
            {
                _minSize = Math.Abs(value);
                RaisePropertyChanged(nameof(MinSize));

                this.Callback?.Invoke();
            }
        }

        private static int _maxSize = DateTime.Today.Year + 1;
        public int MaxSize
        {
            get => _maxSize;
            set
            {
                _maxSize = Math.Abs(value);
                RaisePropertyChanged(nameof(MaxSize));

                this.Callback?.Invoke();
            }
        }


        public AlbumSearchFilterViewModel(Action callback)
        {
            this.Callback = callback;
        }

        public void ApplyFilters(ref List<Album> albums)
        {
            albums = albums
                .Where(album => album.ReleaseYear >= this.MinSize)
                .Where(album => album.ReleaseYear <= this.MaxSize)
                .ToList();
        }

        #region DataValidation
        public string this[string columnName]
        {
            get
            {
                if (columnName == nameof(MinSize) && MinSize > MaxSize)
                    return "Min release year can't be after max release year";
                if (columnName == nameof(MaxSize) && MaxSize < MinSize)
                    return "Max release year can't be before min release year";
                return string.Empty;
            }
        }

        public string Error => string.Empty;
        #endregion



    }
}
