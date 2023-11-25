﻿using Musify.MVVM.Models;
using Musify.MVVM.ViewModels;
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

namespace Musify.MVVM.Views.Confirmation
{
    /// <summary>
    /// Interaction logic for UpdateSongConfirmationWindow.xaml
    /// </summary>
    public partial class UpdateSongConfirmationWindow : Window
    {
        public UpdateSongConfirmationWindow(Guid songId, Song newSong, Action<object> onUpdate)
        {
            InitializeComponent();
            this.DataContext = new UpdateSongConfirmationViewModel(songId, newSong, onUpdate, onClose: (obj) => this.Close()); ;
        }
    }
}
