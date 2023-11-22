using Musify.Models;
using Musify.ViewModels.Albums;
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

namespace Musify.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumSearchFilterWindow.xaml
    /// </summary>
    public partial class AlbumSearchFilterWindow : Window
    {
        private AlbumSearchFilterViewModel _vm;

        public AlbumSearchFilterWindow(Action callback)
        {
            InitializeComponent();

            this._vm = new AlbumSearchFilterViewModel(callback);
            this.DataContext = _vm;
        }

        public void ApplyFilters(ref List<Album> albums)
        {
            this._vm.ApplyFilters(ref albums);
        }
    }
}
