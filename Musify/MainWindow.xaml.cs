using Musify.Models;
using Musify.Utility;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Musify
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await JsonHandler.Add<Song>(new()
            {
                Id = 4,
                Title = "Song title",
                Artist = "Coole artist",
                Duration = 184,
                Genre = "Punk",
                ReleaseDate = DateTime.Now
            });

            var songs = await JsonHandler.GetAll<Song>();

            int x = 9;
        }
    }
}
