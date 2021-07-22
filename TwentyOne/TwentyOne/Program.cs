using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //file class

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text."; // this will be added to log.txt
            //File.WriteAllText(@"C:\Users\8 7\Desktop\TheTechAcademy-C-Sharp-Projects\Logs\log.txt", text);
            //string text = File.ReadAllText(@"C:\Users\8 7\Desktop\TheTechAcademy-C-Sharp-Projects\Logs\log.txt");
            

            Console.WriteLine("Welcome to the Muneshyne Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) //return brings us back to this
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
 