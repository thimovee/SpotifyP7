namespace Spotify7
{
    internal class Client
    {
        public iPlayable CurrentlyPlaying { get; set; }
        public int CurrentTime { get; set; }
        public bool Playing { get; set; }
        public bool Shuffle { get; set; }
        public bool Repeat { get; set; }
        private Playlist SelectedPlaylist;
        public Person ActiveUser;
        private List<Person> users;
        private List<Album> albums;
        private List<Song> songs;
        private List<Playlist> playlists;
        private List<Person> friends;

        public Client(
            List<Person> Name,
            List<Album> aTitle,
            List<Song> sTitle,
            List<Playlist> pName,
            List<Person> FL
        )
        {
            users = Name;
            albums = aTitle;
            songs = sTitle;
            playlists = pName;
            friends = FL;
        }

        // .Count telt alle elementen in een List/Array. Met een for loop en door gebruik te maken van indexes kan je alle elementen in een lijst laten zien
        public void ShowAllAlbums()
        {
            for (int i = 0; i < albums.Count; i++)
            {
                Console.WriteLine(albums[i].Title);
            }
        }

        public void ShowAllSong()
        {
            for (int i = 0; i < songs.Count; i++)
            {
                Console.WriteLine(songs[i].Title);
            }
        }

        public void ShowAllUsers()
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine(users[i].Name);
            }
        }

        public void ShowFriends()
        {
            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine(friends[i].Name);
            }
        }

        public void ShowUserPlaylists()
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine(playlists[i].Title);
            }
        }

        public void ShowPlaylists()
        {
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine(playlists[i].Title);
            }
        }

        //Alle select/set
        public void SelectPlaylist()
        {
            throw new NotImplementedException();
        }

        public void SelectUser()
        {
            throw new NotImplementedException();
        }

        public void SelectUserPlaylist()
        {
            throw new NotImplementedException();
        }

        public void SelectAlbum()
        {
            throw new NotImplementedException();
        }

        public void SelectSong()
        {
            throw new NotImplementedException();
        }

        public void SetActiveUser(Person person)
        {
            ActiveUser = person;
        }

        //Playlists
        public void CreatePlaylist(string Title)
        {
            SelectedPlaylist = ActiveUser.CreatePlaylist(Title);
        }

        public void RemovePlaylist(int playlist)
        {
            ActiveUser.RemovePlaylist(playlists[playlist]);
        }

        public void AddToPlaylist()
        {
            throw new NotImplementedException();
        }

        /*public void ShowSongInPlaylist()
        {
        }*/

        public void RemoveFromPlaylist()
        {
            throw new NotImplementedException();
        }

        //Friends
        public void SelectFriend(int selectFriend)
        {
            Person friend = users.ElementAt(selectFriend);
        }

        public void AddFriend(int addFriend)
        {
            var user = users.ElementAt(addFriend);
            ActiveUser.AddFriends(user);
        }

        public void RemoveFriend(int removeFriend)
        {
            var user = users.ElementAt(removeFriend);
            ActiveUser.RemoveFriends(user);
        }

        //Play, Pause, Stop, NextSong, SetShuffle en Repeat
        public void Play()
        {
            Console.WriteLine("Currently being played: " + CurrentlyPlaying);
        }

        public void Pause()
        {
            Console.WriteLine("Currently paused: " + CurrentlyPlaying);
        }

        public void Stop()
        {
            Console.WriteLine(CurrentlyPlaying + " has stopped playing.");
        }

        public void NextSong()
        {
            CurrentlyPlaying.Next();
            Console.WriteLine("Next song will be playing shortly.");
        }

        public void SetShuffle()
        {
            CurrentlyPlaying.Next();
            Console.WriteLine("Shuffle is currently on.");
        }

        public void SetRepeat()
        {
            Console.WriteLine("Repeat is currently on.");
        }
    }
}
