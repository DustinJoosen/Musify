using Musify.MVVM.ViewModels.Albums;
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
    /// Interaction logic for AlbumSearchWindow.xaml
    /// </summary>
    public partial class AlbumSearchWindow : UserControl
    {
        private Action<object> _goToCreate;
        private Action<object> _goToDetails;
        private Action<object> _goToEdit;

        public AlbumSearchWindow(Action<object> goToCreate, Action<object> goToDetails, Action<object> goToEdit)
        {
            this._goToCreate = goToCreate;
            this._goToDetails = goToDetails;
            this._goToEdit = goToEdit;

            InitializeComponent();
            this.Refresh();
        }

        public void Refresh()
        {
            this.DataContext = new AlbumSearchViewModel(this._goToCreate, this._goToDetails, this._goToEdit);
        }
    }
}
