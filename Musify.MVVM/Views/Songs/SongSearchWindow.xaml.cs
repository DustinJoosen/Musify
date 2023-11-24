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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Musify.MVVM.Views.Songs
{
    /// <summary>
    /// Interaction logic for SongSearchWindow.xaml
    /// </summary>
    public partial class SongSearchWindow : UserControl
    {
        private Action<object> _goToCreate;
        private Action<object> _goToDetails;
        private Action<object> _goToEdit;

        public SongSearchWindow(Action<object> goToCreate, Action<object> goToDetails, Action<object> goToEdit)
        {
            InitializeComponent();

            this._goToCreate = goToCreate;
            this._goToDetails = goToDetails;
            this._goToEdit = goToEdit;

            this.Refresh();
        }

        public void Refresh()
        {
            this.DataContext = new SongSearchViewModel(this._goToCreate, this._goToDetails, this._goToEdit);
        }
    }
}
