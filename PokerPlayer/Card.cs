using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    public enum Rank
    {
        two = 2,
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
        ten,
        jack,
        queen,
        king,
        ace
    }

    public enum Suit
    {
        spade = 1,
        heart,
        clubs,
        diamonds
    }

    class Card
    {
        //properties
        public Rank Rank { get; set; }
        public Suit Suit { get; set; }

        //consructor
        public Card(Rank rank, Suit suit)
        {
            //set our properties
            this.Rank = rank;
            this.Suit = suit;
        }
    }
}
