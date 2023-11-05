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
            this._albumDetailsWindow = new(Guid.Parse("750c217d-735c-477d-bcd3-b811aca15694"));
            this._songCreateWindow = new();
            this._songDetailsWindow = new(Guid.Parse("704c5dd3-7b29-411a-8369-bde2415be1ed"));

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._songDetailsWindow);
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
