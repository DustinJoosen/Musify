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
        private SongDetailsWindow _songDetailsWindow;

        public Main()
        {
            InitializeComponent();
            InitializeNavbar();

            // Define all screen constants
            this._albumCreateWindow = new();
            this._albumDetailsWindow = new(Guid.Parse("14c94e75-50b7-439c-883b-de122a840b52"));
            this._songCreateWindow = new();
            this._songDetailsWindow = new(Guid.Parse("1179e276-435d-4c26-8439-c21ae5e859c3"));

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumCreateWindow);
        }


        // Because of the linking to other windoes, navbar is initialized in Main.
        private void InitializeNavbar()
        {
            this.navControl.Content = new NavigationWindow();
            var navigationVM = new NavigationWindowViewModel();

            navigationVM.OnExitProgram += (obj, sen) => Environment.Exit(0);
            navigationVM.OnGoToAlbums += (obj, sen) => this.SetWindow(this._albumCreateWindow);
            navigationVM.OnGoToSongs += (obj, sen) => this.SetWindow(this._songCreateWindow);

            navigationVM.LoadEvents();

            this.navControl.DataContext = navigationVM;
        }

        public void SetWindow(UserControl? control) => 
            this.contentControl.Content = control;
    }
}
