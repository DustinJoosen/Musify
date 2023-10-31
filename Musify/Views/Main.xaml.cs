using Musify.Views.Albums;
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

namespace Musify.Views
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        // Screen constants.
        private AlbumCreateWindow _albumCreateWindow;
        private AlbumDetailsWindow _albumDetailsWindow;

        // Delegates.
        private delegate void WindowSender();

        public Main()
        {
            InitializeComponent();

            // Define all screen constants.
            this._albumCreateWindow = new();
            this._albumDetailsWindow = new();

            // Define all events.
            this._albumCreateWindow.GoToMainWindow += (sender, args) => this.SetWindow(this._albumDetailsWindow);
            this._albumDetailsWindow.GoToMainWindow += (sender, args) => this.SetWindow(this._albumCreateWindow);

            // The startup usercontrol. When made, add the dashboard here.
            this.SetWindow(this._albumCreateWindow);
        }

        public void SetWindow(UserControl? control) => 
            this.contentControl.Content = control;
    }
}
