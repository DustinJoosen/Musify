using Musify.MVVM.Utility;
using Musify.MVVM.ViewModels;
using Musify.MVVM.Views.Albums;
using Musify.MVVM.Views.Songs;
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

namespace Musify.MVVM.Views
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
        private AlbumDeleteWindow _albumDeleteWindow;

        private SongSearchWindow _songSearchWindow;
        private SongCreateWindow _songCreateWindow;
        private SongDetailsWindow _songDetailsWindow;
        private SongUpdateWindow _songUpdateWindow;
        private SongDeleteWindow _songDeleteWindow;

        public Main()
        {
            InitializeComponent();
            InitializeNavbar();

            // Actions to go back to the search windows
            Action<object> goBackToAlbums = (obj) =>
            {
                this._albumSearchWindow.Refresh();
                this.SetWindow(this._albumSearchWindow);
            };

            Action<object> goBackToSongs = (obj) =>
            {
                this._songSearchWindow.Refresh();
                this.SetWindow(this._songSearchWindow);
            };

            // Album windows.
            this._albumSearchWindow = new(
                goToCreate: (obj) =>
                {
                    this._albumCreateWindow = new(goBackToAlbums);
                    this.SetWindow(this._albumCreateWindow);
                },
                goToDetails: (obj) =>
                {
                    this._albumDetailsWindow = new(Guid.Parse(obj.ToString()), goBackToAlbums);
                    this.SetWindow(this._albumDetailsWindow);
                },
                goToEdit: (obj) =>
                {
                    this._albumUpdateWindow = new(Guid.Parse(obj.ToString()), goBackToAlbums);
                    this.SetWindow(this._albumUpdateWindow);
                },
                goToDelete: (obj) =>
                {
                    this._albumDeleteWindow = new(Guid.Parse(obj.ToString()), goBackToAlbums);
                    this.SetWindow(this._albumDeleteWindow);
                });

            // Song windows
            this._songSearchWindow = new(
                goToCreate: (obj) =>
                {
                    this._songCreateWindow = new(goBackToSongs);
                    this.SetWindow(this._songCreateWindow);
                },
                goToDetails: (obj) =>
                {
                    this._songDetailsWindow = new(Guid.Parse(obj.ToString()),
                        backToSearch: goBackToSongs,
                        goToEdit: (obj2) =>
                        {
                            this._songUpdateWindow = new(Guid.Parse(obj2.ToString()), goBackToSongs);
                            this.SetWindow(this._songUpdateWindow);
                        });
                    this.SetWindow(this._songDetailsWindow);
                },
                goToEdit: (obj) =>
                {
                    this._songUpdateWindow = new(Guid.Parse(obj.ToString()), goBackToSongs);
                    this.SetWindow(this._songUpdateWindow);
                },
                goToDelete: (obj) =>
                {
                    this._songDeleteWindow = new(Guid.Parse(obj.ToString()), goBackToSongs);
                    this.SetWindow(this._songDeleteWindow);
                });


            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumSearchWindow);
        }

        private void InitializeNavbar()
        {
            this.navControl.Content = new NavigationWindow();
        
            var navigationVM = new NavigationWindowViewModel(
                onGoToAlbums: (obj) => this.SetWindow(this._albumSearchWindow),
                onGoToSongs: (obj) => this.SetWindow(this._songSearchWindow));

            this.navControl.DataContext = navigationVM;
        }

        public void SetWindow(UserControl? control) =>
            this.contentControl.Content = control;
    }
}
