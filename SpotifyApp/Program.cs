// See https://aka.ms/new-console-template for more information
using SpotifyApp.Entities;
using SpotifyApp.Services;

Console.WriteLine("Hello, World!");

Song song1 = new Song
{
    Id = Guid.NewGuid(),
    Title = "Für Elise",
    Artist = "Ludwig van Beethoven",
    Producer = "Yapımcı 1",
    Composer = "Ludwig van Beethoven"
};

Song song2 = new Song
{
    Id = Guid.NewGuid(),
    Title = "Sonat No. 14 (Ay Işığı)",
    Artist = "Ludwig van Beethoven",
    Producer = "Yapımcı 2",
    Composer = "Ludwig van Beethoven"
};

Song song3 = new Song
{
    Id = Guid.NewGuid(),
    Title = "Canon in D",
    Artist = "Johann Pachelbel",
    Producer = "Yapımcı 3",
    Composer = "Johann Pachelbel"
};

Song song4 = new Song
{
    Id = Guid.NewGuid(),
    Title = "Beşinci Senfoni",
    Artist = "Ludwig van Beethoven",
    Producer = "Yapımcı 4",
    Composer = "Ludwig van Beethoven"
};

Song song5 = new Song
{
    Id = Guid.NewGuid(),
    Title = "Kışın Dört Mevsimi (Kış)",
    Artist = "Antonio Vivaldi",
    Producer = "Yapımcı 5",
    Composer = "Antonio Vivaldi"
};


Playlist playlist = new Playlist(new List<Song> { song1, song2, song3, song4, song5 });
NotepadService notepadService = new NotepadService();

notepadService.WriteToNotepad(playlist);


