namespace Spotify7
{
    internal class Album : SongCollection
    {
        public List<Artist> Artists;

        public Album(List<Artist> artist, string title, List<Song> SongTitle) : base(title)
        {
            Artists = artist;
            Title = title;
            var Song = new List<Song>();
        }

        //Override ToString
        public override string ToString()
        {
            return ("Song: " + Title + "\nArtists: " + Artists);
        }
    }
}
