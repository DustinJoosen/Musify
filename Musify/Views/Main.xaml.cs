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
        private AlbumSearchWindow _albumSearchWindow;
        private AlbumCreateWindow _albumCreateWindow;
        private AlbumDetailsWindow _albumDetailsWindow;
        private AlbumUpdateWindow _albumUpdateWindow;
        private SongCreateWindow _songCreateWindow;
        private SongDetailsWindow _songDetailsWindow;
        private SongUpdateWindow _songUpdateWindow;

        public Main()
        {
            InitializeComponent();
            InitializeNavbar();

            // Define all screen constants
            Action<object> goBack = (obj) =>
            {
                this._albumSearchWindow.Refresh();
                this.SetWindow(this._albumSearchWindow);
            };

            // Album windows.
            this._albumSearchWindow = new(
                goToCreate: (obj) =>
                {
                    this._albumCreateWindow = new(goBack);
                    this.SetWindow(this._albumCreateWindow);
                },
                goToDetails: (obj) =>
                {
                    this._albumDetailsWindow = new(Guid.Parse(obj.ToString()), goBack);
                    this.SetWindow(this._albumDetailsWindow);
                },
                goToEdit: (obj) =>
                {
                    this._albumUpdateWindow = new(Guid.Parse(obj.ToString()), goBack);
                    this.SetWindow(this._albumUpdateWindow);
                });
            
            // Song windows
            this._songCreateWindow = new();
            this._songDetailsWindow = new(Guid.Parse("1179e276-435d-4c26-8439-c21ae5e859c3"));
            this._songUpdateWindow = new(Guid.Parse("1179e276-435d-4c26-8439-c21ae5e859c3"));

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumSearchWindow);
        }


        // Because of the linking to other windoes, navbar is initialized in Main.
        private void InitializeNavbar()
        {
            this.navControl.Content = new NavigationWindow();
            var navigationVM = new NavigationWindowViewModel();

            navigationVM.OnExitProgram += (obj, sen) => Environment.Exit(0);
            navigationVM.OnGoToAlbums += (obj, sen) => this.SetWindow(this._albumSearchWindow);
            navigationVM.OnGoToSongs += (obj, sen) => this.SetWindow(this._songCreateWindow);

            navigationVM.LoadEvents();

            this.navControl.DataContext = navigationVM;
        }

        public void SetWindow(UserControl? control) =>
            this.contentControl.Content = control;
    }
}
