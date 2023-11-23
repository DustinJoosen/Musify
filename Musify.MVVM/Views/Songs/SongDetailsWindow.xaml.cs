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

namespace Musify.MVVM.Views.Songs
{
    /// <summary>
    /// Interaction logic for SongDetailsWindow.xaml
    /// </summary>
    public partial class SongDetailsWindow : UserControl
    {
        public SongDetailsWindow(Guid id)
        {
            InitializeComponent();
            this.DataContext = new SongDetailViewModel(id);
        }
    }
}
