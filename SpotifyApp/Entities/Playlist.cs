using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.Entities
{
    internal class Playlist
    {
        public Guid Id { get; set; }

        private List<Song> Songs { get; set; }

        Random random;

        private Playlist()
        {
            Id = Guid.NewGuid();
            Songs = new List<Song>();
            random = new Random();
        }

        public Playlist(Song song) : this()
        {
            AddSong(song);
        }

        public Playlist(List<Song> songList) : this()
        {
            foreach (Song song in songList)
            {
                AddSong(song);
            }
        }

        public void AddSong(Song song)
        {
            if(isSongTitleValid(song))
                Songs.Add(song);
        }

        private bool isSongTitleValid(Song song)
        {
            return !string.IsNullOrEmpty(song.Title)
            && song.Title.Length > 2
            && song.Title.Length < 30;
                
        }

        public string GetSongs()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(Song song in Songs)
            {
                stringBuilder.Append($"Song: {song.Title} Composer: {song.Composer}\n");
            }

            return stringBuilder.ToString();
        }

        public void ShowSongs()
        {
            
            foreach(Song song in Songs)
            {
                Console.WriteLine($"Title {song.Title} - {song.Composer}");
            }
        }

        public void ShuffleSongs()
        {
            int songsCount = Songs.Count;

            while( songsCount > 0 )
            {
                songsCount--;

                Song song = Songs[songsCount];

                Song swapSong = Songs[random.Next(songsCount)];
                
            }
        }


    }
}
