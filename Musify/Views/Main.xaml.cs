using Musify.ViewModels;
using Musify.Views.Albums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Musify.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        // Screen constants.
        private AlbumCreateWindow _albumCreateWindow;
        private AlbumDetailsWindow _albumDetailsWindow;

        public Main()
        {
            InitializeComponent();

            // Set navbar
            this.navControl.Content = new NavigationWindow();
            var navigationVM = new NavigationWindowViewModel();

            navigationVM.OnExitProgram += (obj, sen) => Environment.Exit(0);
            navigationVM.OnGoToAlbums += (obj, sen) => this.SetWindow(this._albumDetailsWindow);
            navigationVM.OnGoToSongs += (obj, sen) => this.SetWindow(this._albumCreateWindow);

            navigationVM.LoadEvents();

            this.navControl.DataContext = navigationVM;

            // Define all screen constants.
            this._albumCreateWindow = new();
            this._albumDetailsWindow = new();

            // Define all events (minus navbar).
            this._albumCreateWindow.GoToMainWindow += (sender, args) => this.SetWindow(this._albumDetailsWindow);
            this._albumCreateWindow.DataContext = new AlbumViewModel();

            this._albumDetailsWindow.GoToMainWindow += (sender, args) => this.SetWindow(this._albumCreateWindow);

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumCreateWindow);
        }

        public void SetWindow(UserControl? control) => 
            this.contentControl.Content = control;
    }
}
