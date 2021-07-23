using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class Deck
    {
        // constructor
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i <13; i++ )
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }
            //List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            //List<string> Faces = new List<string>()
            //{
            //    "Two", "Three", "Four", "Five", "Six", "Seven",
            //    "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            //};

            ////nested foreach loop
            //foreach (string face in Faces)
            //{
            //    //foreach (string suit in Suits) //creates for cards of each suit and face
            //    //{
            //    //    Card card = new Card();
            //    //    card.Suit = suit;
            //    //    card.Face = face;
            //    //    Cards.Add(card);
            //    //}
            //}
        }
        public List<Card> Cards { get; set; }


        // method to shuffle cards and put them back in the deck
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count); // 0 to 52
                    TempList.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
