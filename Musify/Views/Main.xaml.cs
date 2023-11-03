using Musify.Utility;
using Musify.ViewModels;
using Musify.Views.Albums;
using Musify.Views.Songs;
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
        private SongCreateWindow _songCreateWindow;

        public Main()
        {
            InitializeComponent();

            // Set navbar
            this.navControl.Content = new NavigationWindow();
            var navigationVM = new NavigationWindowViewModel();

            navigationVM.OnExitProgram += (obj, sen) => Environment.Exit(0);
            navigationVM.OnGoToAlbums += (obj, sen) => this.SetWindow(this._albumCreateWindow);
            navigationVM.OnGoToSongs += (obj, sen) => this.SetWindow(this._songCreateWindow);

            navigationVM.LoadEvents();

            this.navControl.DataContext = navigationVM;

            // Define all screen constants.
            this._albumCreateWindow = new();
            this._albumDetailsWindow = new();
            this._songCreateWindow = new();

            // Define all events (minus navbar).
            var avm = new AlbumViewModel(Guid.Parse("c90db429-b0ce-4b58-8122-41b9d6b316ce"))
            {
                CreateWindow = this._albumCreateWindow,
            };

            var scvm = new SongCreateViewModel();

            this._albumCreateWindow.DataContext = avm;
            this._albumDetailsWindow.DataContext = avm;
            this._songCreateWindow.DataContext = scvm;

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._songCreateWindow);
        }

        public void SetWindow(UserControl? control) => 
            this.contentControl.Content = control;
    }
}
