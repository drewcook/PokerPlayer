using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    class Deck
    {
        //properties
        public List<Card> Contents { get; set; }
        public List<Card> DealtCards { get; set; }

        //constructor
        public Deck()
        {
            //generate contents
            this.Contents = new List<Card>();
            for (int i = 1; i < 5; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    this.Contents.Add(new Card((Rank)j, (Suit)i));
                }
            }

            //dealtcards
            this.DealtCards = new List<Card>();
        }

        //Methods and Functions

        //Function to Shuffle
        public void Shuffle()
        {
            //get all the card back
            this.Contents.AddRange(this.DealtCards);

            //clear the dealt cards
            this.DealtCards.Clear();

            //make a random number generator
            Random rng = new Random();

            for (int i = 0; i < this.Contents.Count; i++)
            {
                int randCard = rng.Next(this.Contents.Count - i);
                this.Contents.Add(this.Contents[randCard]);
                this.Contents.RemoveAt(randCard);
            }
        }

        //Function to Deal
        public List<Card> Deal(int num)
        {
            List<Card> newDeal = this.Contents.Take(num).ToList();
            this.DealtCards.AddRange(this.Contents.Take(num).ToList());
            this.Contents.RemoveRange(0, num);
            return newDeal;
        }
    }
}
