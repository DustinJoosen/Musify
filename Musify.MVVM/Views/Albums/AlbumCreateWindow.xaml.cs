﻿using Musify.MVVM.Models;
using Musify.MVVM.Utility;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Musify.MVVM.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumCreateWindow.xaml
    /// </summary>
    public partial class AlbumCreateWindow : UserControl
    {
        public AlbumCreateWindow(Action<object> goBack)
        {
            InitializeComponent();
            this.DataContext = new AlbumCreateViewModel(goBack);
        }

    }
}
