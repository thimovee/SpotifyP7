namespace Spotify7
{
    internal class Song : iPlayable
    {
        public string Title;
        public List<Artist> Artists;
        public int Length;
        public Genre SongGenre;

        public Song(string title, List<Artist> artists, int length, Genre songGenre)
        {
            Title = title;
            Artists = artists;
            Length = length;
            SongGenre = songGenre;
        }

        public override string ToString()
        {
            return "Title: "
                + Title
                + "\nArtist: "
                + Artists
                + "\nGenre: "
                + SongGenre
                + "\nLength: "
                + Length;
        }

        public void Play()
        {
            Console.WriteLine(ToString() + " \nis currently playing.");
        }

        public void Pause()
        {
            Console.WriteLine(ToString() + " \nhas been paused.");
        }

        public void Next()
        {
            Console.WriteLine(ToString() + " \nis currently playing.");
        }

        public void Stop()
        {
            Console.WriteLine(ToString() + " \nhas stopped playing.");
        }
    }
}
