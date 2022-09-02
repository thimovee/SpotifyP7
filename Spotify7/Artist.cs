namespace Spotify7
{
    internal class Artist
    {
        public string Name;
        public List<Album> Albums;
        public List<Song> Song;

        public Artist(string name, List<Album> albums, List<Song> songs)
        {
            Name = name;
            Albums = albums;
            Song = new List<Song>();
        }

        public void AddSong(Song song)
        {
            Song.Add(song);
        }

        public void AddAlbum(Album album)
        {
            Albums.Add(album);
        }

        //Override ToString
        public string ToString(string name, List<Album> album, List<Song> songs)
        {
            return ("Artist: " + name + "\nAlbums: " + album + "\nSongs: " + songs);
        }
    }
}
