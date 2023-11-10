using Musify.ViewModels;
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

namespace Musify.Views.Confirmation
{
    /// <summary>
    /// Interaction logic for RemoveSongFromAlbumConfirmationWindow.xaml
    /// </summary>
    public partial class RemoveSongFromAlbumConfirmationWindow : Window
    {

        public RemoveSongFromAlbumConfirmationWindow(Guid id, Action<object> onDeleteConfirmation)
        {
            InitializeComponent();
            this.DataContext = new RemoveSongFromAlbumConfirmationViewModel(id, onDeleteConfirmation, (obj) => this.Close());
        }
    }
}
