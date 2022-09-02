namespace Spotify7
{
    internal class Person
    {
        public string Name;
        public List<Person> Friends;
        public List<Playlist> Playlists;
        public Playlist CurrentPlaylist;

        public Person(string name)
        {
            Name = name;
            Friends = new List<Person>();
            var Playlist = new List<Playlist>();
        }

        public List<Person> ShowFriends()
        {
            return Friends;
        }

        public void AddFriends(Person person)
        {
            Friends.Add(person);
        }

        public void RemoveFriends(Person person)
        {
            Friends.Remove(person);
        }

        public List<Playlist> ShowPlaylists()
        {
            return Playlists;
        }

        public Playlist SelectPlaylist(int num)
        {
            throw new NotImplementedException();
        }

        public Playlist CreatePlaylist(string Title)
        {
            Playlist newPlaylist = new Playlist(this, Title);
            Playlists.Add(newPlaylist);
            return newPlaylist;
        }

        public void RemovePlaylist(Playlist playlist)
        {
            Playlists.Remove(playlist);
        }

        public void AddToPlaylist(iPlayable i, Playlist cur)
        {
            Playlist t = Playlists.Where(x => x.Title.Contains(cur.Title)).Single();
            t.Add(i);
        }

        public void RemoveFromPlaylist(iPlayable i, Playlist cur)
        {
            Playlist t = Playlists.Where(x => x.Title.Contains(cur.Title)).Single();
            t.Remove(i);
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nFriends: " + Friends + "\nPlaylists: " + Playlists;
        }
    }
}
