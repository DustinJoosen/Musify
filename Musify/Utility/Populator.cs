using Musify.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Musify.Utility
{
    // We need a standard population, for the rubrix.
    // Can be done gradually. Just adding things you like.
    public static class Populator
    {
        // Adds a handful of testing data.
        public static void Populate()
        {
            Task.Run(async () =>
            {
                await Populator.PopulateSongs();
                await Populator.PopulateAlbums();
            });
        }

        public static async Task PopulateSongs()
        {
            await JsonHandler.Add<Song>(new()
            {
                Title = "Back in Black",
                Artist = "AC/DC",
                Genre = "Rock",
                ReleaseDate = DateTime.Now,
                Duration = 417
            });
        }

        public static async Task PopulateAlbums()
        {

        }


    }
}