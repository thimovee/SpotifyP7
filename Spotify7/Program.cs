namespace Spotify7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input1 = "";
            string input2 = "";
            var users = new List<Person>();
            var songs = new List<Song>();
            var artists = new List<Artist>();
            var album = new List<Album>();
            var playlists = new List<Playlist>();
            var friendlist = new List<Person>();
            Person persoon1 = new Person("Thimo");
            Person persoon2 = new Person("Robert");
            Person persoon3 = new Person("Gert");
            Song song1 = new Song("song1", artists, 100, Genre.Country);
            Song song2 = new Song("song2", artists, 100, Genre.Country);
            Song song3 = new Song("song3", artists, 100, Genre.Country);
            Artist artist1 = new Artist("Artist1", null, null);
            Artist artist2 = new Artist("Artist2", null, null);
            Artist artist3 = new Artist("Artist3", null, null);
            artists.Add(artist1);
            artists.Add(artist2);
            artists.Add(artist3);
            users.Add(persoon1);
            users.Add(persoon2);
            users.Add(persoon3);
            songs.Add(song1);
            songs.Add(song2);
            songs.Add(song3);
            Client client = new Client(users, album, songs, playlists, friendlist);
            menu();

            if (client.ActiveUser == null)
            {
                Console.WriteLine("No user selected type 2 to change/select user!");
            }

            void menu()
            {
                Console.WriteLine("Welcome: " + client.ActiveUser + "!");
                Console.WriteLine("1) Change user");
                Console.WriteLine("2) Playlist");
                Console.WriteLine("3) Userlist");
                Console.WriteLine("4) Friends");
                Console.WriteLine("5) Song");
                Console.WriteLine("6) Albums");
                Console.WriteLine("Enter your choice: ");
                input1 = Console.ReadLine();
                inputMenu(input1);
            }

            void inputMenu(string input1)
            {
                switch (input1)
                {
                    case "1":
                        Console.WriteLine("What user do you want to change to?");
                        input2 = Console.ReadLine();
                        if (input2 == "Thimo")
                        {
                            client.SetActiveUser(persoon1);
                            Console.WriteLine(client.ActiveUser + " has been set as active user");
                            menu();
                        }
                        else if (input2 == "Robert")
                        {
                            client.SetActiveUser(persoon2);
                            Console.WriteLine(client.ActiveUser + " has been set as active user");
                            menu();
                        }
                        else
                        {
                            Console.WriteLine("Only valid response is either Thimo or Robert!");
                            menu();
                        }
                        break;
                    case "2":
                        Console.WriteLine("1) View playlists");
                        Console.WriteLine("2) Select a playlist");
                        Console.WriteLine("3) Create a playlist");
                        input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            client.ShowUserPlaylists();
                            menu();
                        }
                        if (input2 == "2")
                        {
                            Console.WriteLine("Select a playlist:");
                            int i = Convert.ToInt32(Console.ReadLine());
                            //client.SelectPlaylist(i);
                            menu();
                        }
                        if (input2 == "3")
                        {
                            Console.WriteLine("What is the name of the playlist:");
                            string s = Convert.ToString(Console.ReadLine());
                            if (s == "")
                            {
                                Console.WriteLine("Invalid response, enter a string.");
                                menu();
                            }
                            else
                            {
                                client.CreatePlaylist(s);
                                menu();
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("1) View all active users");
                        input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            client.ShowAllUsers();
                            menu();
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                            menu();
                        }
                        break;
                    case "4":
                        Console.WriteLine("1) View Friendlist.");
                        Console.WriteLine("2) Add Friends");
                        Console.WriteLine("3) Remove Friends");
                        input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            client.ShowFriends();
                            menu();
                        }
                        else if (input2 == "2")
                        {
                            client.ShowAllUsers();
                            Console.WriteLine("Who would you like to add as  your friend?");
                            int i = Convert.ToInt32(Console.ReadLine());
                            client.AddFriend(i);
                            menu();
                        }
                        else if (input2 == "3")
                        {
                            client.ShowFriends();
                            Console.WriteLine("What friend do you want to remove?");
                            input2 = Console.ReadLine();
                            if (input2 == "0")
                            {
                                client.RemoveFriend(0);
                                menu();
                            }
                            else if (input2 == "1")
                            {
                                client.RemoveFriend(1);
                                menu();
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("1) Show all songs");
                        Console.WriteLine("2) Play song");
                        input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            client.ShowAllSong();
                        }
                        if (input2 == "2")
                        {
                            Console.WriteLine("What song do you want to play:");
                            int i = Convert.ToInt32(Console.ReadLine());
                            //client.SelectSong(i);
                            menu();
                        }
                        break;
                    case "6":
                        Console.WriteLine("1) Show all album");
                        Console.WriteLine("2) Play album");
                        input2 = Console.ReadLine();
                        if (input2 == "1")
                        {
                            client.ShowAllAlbums();
                            menu();
                        }
                        if (input2 == "2")
                        {
                            Console.WriteLine("What album do you want to play:");
                            int i = Convert.ToInt32(Console.ReadLine());
                            //client.SelectSong(i);
                            menu();
                        }
                        break;
                }
            }
        }
    }
}