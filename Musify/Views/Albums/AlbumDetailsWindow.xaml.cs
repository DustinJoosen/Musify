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

namespace Musify.Views.Albums
{
    /// <summary>
    /// Interaction logic for AlbumDetailsWindow.xaml
    /// </summary>
    public partial class AlbumDetailsWindow : UserControl
    {
        public event EventHandler GoToMainWindow;

        public AlbumDetailsWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.GoToMainWindow?.Invoke(this, EventArgs.Empty);
        }

    }
}
