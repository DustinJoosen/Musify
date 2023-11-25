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
        private Action<object> _goToDelete;

        public AlbumSearchWindow(Action<object> goToCreate, Action<object> goToDetails, 
            Action<object> goToEdit, Action<object> goToDelete)
        {
            this._goToCreate = goToCreate;
            this._goToDetails = goToDetails;
            this._goToEdit = goToEdit;
            this._goToDelete = goToDelete;

            InitializeComponent();
            this.Refresh();
        }

        public void Refresh()
        {
            this.DataContext = new AlbumSearchViewModel(this._goToCreate, this._goToDetails, this._goToEdit, this._goToDelete);
        }
    }
}
