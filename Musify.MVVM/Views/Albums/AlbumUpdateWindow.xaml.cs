﻿using Musify.MVVM.ViewModels.Albums;
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
    /// Interaction logic for AlbumUpdateWindow.xaml
    /// </summary>
    public partial class AlbumUpdateWindow : UserControl
    {
        public AlbumUpdateWindow(Guid id, Action<object> goBack)
        {
            InitializeComponent();
            this.DataContext = new AlbumUpdateViewModel(id, goBack);
        }
    }
}
