﻿using Musify.MVVM.ViewModels;
using Musify.MVVM.ViewModels.Songs;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Musify.MVVM.Views.Songs
{
    /// <summary>
    /// Interaction logic for SongUpdate.xaml
    /// </summary>
    public partial class SongUpdateWindow : UserControl
    {
        public SongUpdateWindow(Guid id, Action<object> goBackToSongs)
        {
            InitializeComponent();
            this.DataContext = new SongUpdateViewModel(id, goBackToSongs);
        }
    }
}
