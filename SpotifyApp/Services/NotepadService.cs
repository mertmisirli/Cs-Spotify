using SpotifyApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Services
{
    internal class NotepadService
    {
        public void WriteToNotepad(Playlist playlist)
        {
            string directory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.Parent?.FullName;

            if(!Directory.Exists(directory))
                Directory.CreateDirectory(directory);

            string saveFile = Path.Combine(directory, $"{playlist.Id}.txt");

            File.WriteAllText(saveFile, playlist.GetSongs());
        }
    }
}
