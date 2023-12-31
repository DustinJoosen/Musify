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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Musify.MVVM.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumDetailsWindow.xaml
    /// </summary>
    public partial class AlbumDetailsWindow : UserControl
    {
        public AlbumDetailsWindow(Guid id, Action<object> goBack)
        {
            InitializeComponent();
            this.DataContext = new AlbumDetailViewModel(id, goBack);
        }

    }
}
