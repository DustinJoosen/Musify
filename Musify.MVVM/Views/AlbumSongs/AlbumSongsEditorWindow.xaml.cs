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

namespace Musify.MVVM.Views.AlbumSongs
{
    /// <summary>
    /// Interaction logic for AlbumSongsEditorWindow.xaml
    /// </summary>
    public partial class AlbumSongsEditorWindow : Window
    {
        public event Action<object> Callback;

        public AlbumSongsEditorWindow(Guid albumId)
        {
            InitializeComponent();
            this.DataContext = new AlbumSongEditorViewModel(albumId, (obj) =>
            {
                this.Close();
                this.Callback?.Invoke(obj);
            });
        }

        // TODO: Ask a teacher why it isn't working.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!(sender is Button btn))
                return;

            var context = (AlbumSongEditorViewModel)this.DataContext;
            context.RemoveSong(btn.CommandParameter);
        }
    }
}
