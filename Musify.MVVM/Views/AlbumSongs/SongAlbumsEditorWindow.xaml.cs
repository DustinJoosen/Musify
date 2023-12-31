﻿using Musify.MVVM.ViewModels;
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

namespace Musify.MVVM.Views.AlbumSongs
{
    /// <summary>
    /// Interaction logic for SongAlbumsEditorWindow.xaml
    /// </summary>
    public partial class SongAlbumsEditorWindow : Window
    {
        public event Action<object> Callback;

        public SongAlbumsEditorWindow(Guid albumId)
        {
            InitializeComponent();
            this.DataContext = new SongAlbumsEditorViewModel(albumId, (obj) =>
            {
                this.Close();
                this.Callback?.Invoke(obj);
            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button btn))
                return;

            var context = (SongAlbumsEditorViewModel)this.DataContext;
            context.RemoveAlbum(btn.CommandParameter);
        }
    }
}
