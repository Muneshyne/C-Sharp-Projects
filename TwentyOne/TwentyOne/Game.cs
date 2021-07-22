using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //keep names generic ie not TwentyOneGame
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }

        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }

        // can type prop then tab x2 to set public property
        public abstract void Play(); //no implementation

        public virtual void ListPlayers() // does have implementation
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
