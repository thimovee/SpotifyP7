namespace Spotify7
{
    internal class SongCollection : iPlayable
    {
        public string Title;
        private List<iPlayable> playables;
        public int Length;

        public SongCollection(string title)
        {
            Title = title;
            playables = new List<iPlayable>();
        }

        public void Play()
        {
            Console.WriteLine(Title + " is currently being played.");
        }

        public void Pause()
        {
            Console.WriteLine(Title + " has been paused.");
        }

        public void Next()
        {
            Console.WriteLine(Title + " will start playing.");
        }

        public void Stop()
        {
            Console.WriteLine(Title + " has stopped playing.");
        }

        public List<iPlayable> ShowPlayables()
        {
            return playables;
        }

        public override string ToString()
        {
            return ("Collection Title: " + Title);
        }
    }
}
