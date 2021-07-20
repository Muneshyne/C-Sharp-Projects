using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //keep names generic ie not TwentyOneGame
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
        // can type prop then tab x2 to set public property
        public abstract void Play(); //no implementation

        public virtual void ListPlayers() // does have implementation
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
