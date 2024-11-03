using System;

namespace ListOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            //Player player1 = new Player("Chad");
            //Player player2 = new Player("Steve");
            //Player player3 = new Player("Karen");


            // Anonymous objects
            players.Add(new Player("Chad"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Karen"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }

            Console.ReadKey();
        }
    }
    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}