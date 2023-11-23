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
        public event EventHandler OnGoToAlbums;
        public event EventHandler OnGoToSongs;
        public event EventHandler OnExitProgram;

        public ICommand GoToDashboard { get; set; }
        public ICommand GoToAlbums { get; set; }
        public ICommand GoToSongs { get; set; }
        public ICommand ExitProgram { get; set; }

        public void LoadEvents()
        {
            this.GoToAlbums = this.GetCommandFromEvent(this.OnGoToAlbums);
            this.GoToSongs = this.GetCommandFromEvent(this.OnGoToSongs);
            this.ExitProgram = this.GetCommandFromEvent(this.OnExitProgram);
        }

        public RelayCommand GetCommandFromEvent(EventHandler? evnt) =>
            new RelayCommand((obj) => evnt(this, EventArgs.Empty));
    }
}