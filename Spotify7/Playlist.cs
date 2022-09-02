namespace Spotify7
{
    internal class Playlist : SongCollection, iPlayable
    {
        private List<iPlayable> playables;
        public Person Owner;

        public Playlist(Person activeUser, string Title) : base(Title)
        {
            Owner = activeUser;
            this.Title = Title;
        }

        public void Add(iPlayable iPlayable)
        {
            if (iPlayable != null)
            {
                playables.Add(iPlayable);
            }
        }

        public void Remove(iPlayable iPlayable)
        {
            if (iPlayable != null)
            {
                playables.Remove(iPlayable);
            }
        }

        //Override ToString
        public override string ToString()
        {
            return ("Playlist owner: " + Owner + "\nPlaylist Name: " + Title);
        }
    }
}
