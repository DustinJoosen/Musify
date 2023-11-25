using Musify.MVVM.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Musify.MVVM.ViewModels
{
    public class NavigationWindowViewModel : NotifyPropertyChanged
    {
        public ICommand GoToAlbums { get; set; }
        public ICommand GoToSongs { get; set; }
        public ICommand ExitProgram { get; set; }

        public NavigationWindowViewModel(Action<object> onGoToAlbums, Action<object> onGoToSongs)
        {
            this.GoToAlbums = new RelayCommand(onGoToAlbums);
            this.GoToSongs = new RelayCommand(onGoToSongs);

            this.ExitProgram = new RelayCommand((obj) => Environment.Exit(0));
        }
    }
}