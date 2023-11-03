﻿using Musify.Utility;
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

            // Define all screen constants and their view models.
            this._albumCreateWindow = new();
            this._albumDetailsWindow = new();
            this._songCreateWindow = new();
            this._songDetailsWindow = new();

            var acvm = new AlbumCreateViewModel() { CreateWindow = this._albumCreateWindow };
            var advm = new AlbumDetailViewModel(Guid.Parse("b40299e3-fbf7-4dcf-b595-f1f00992e87d"));
            var scvm = new SongCreateViewModel();
            var sdvm = new SongDetailViewModel(Guid.Parse("f3a621c5-ef61-444d-ae90-bd0d65f10984"));

            this._albumCreateWindow.DataContext = acvm;
            this._albumDetailsWindow.DataContext = advm;
            this._songCreateWindow.DataContext = scvm;
            this._songDetailsWindow.DataContext = sdvm;

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumCreateWindow);
        }

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
