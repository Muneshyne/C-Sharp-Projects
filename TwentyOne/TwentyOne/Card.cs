using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public struct Card // good practice to have 1 class per file
    {
        //constructor method name is always the name of the class
        //public Card()
        //{
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        public Suit Suit { get; set; } //properties
        public Face Face { get; set; }

        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);
        }
    }
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
       Two, Three, Four, Five, Six, Seven,
       Eight, Nine, Ten, Jack, Queen, King, Ace
    }
}
