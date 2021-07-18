using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card // good practice to have 1 class per file
    {
        //constructor method name is always the name of the class
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }
        public string Suit { get; set; } //properties
        public string Face { get; set; }
    }
}
