using Musify.MVVM.Models;
using Musify.MVVM.ViewModels.Albums;
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
using System.Windows.Shapes;

namespace Musify.MVVM.Views.Songs
{
    /// <summary>
    /// Interaction logic for SongSearchFilterWindow.xaml
    /// </summary>
    public partial class SongSearchFilterWindow : Window
    {
        private SongSearchFilterViewModel _vm;

        public SongSearchFilterWindow(Action callback)
        {
            InitializeComponent();

            this._vm = new SongSearchFilterViewModel(callback);
            this.DataContext = _vm;

        }

        public void ApplyFilters(ref List<Song> songs)
        {
            this._vm.ApplyFilters(ref songs);
        }
    }
}
