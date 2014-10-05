using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    public enum HandRank
    {
        HighCard, OnePair, TwoPair, ThreeKind, Straight, Flush, FullHouse, FourKind, StraightFlush, RoyalFlush

    }
    class PokerPlayer
    {
        //set properties
        public List<Card> HandContents { get; set; }
        public HandRank HandRank { get; set; }

        //construct properties
        public PokerPlayer()
        {
            this.HandRank = (HandRank)0;
            this.HandContents = new List<Card>();
        }

        //functions and methods
        public void DrawHand(List<Card> HandDealt)
        {
            HandRank = (HandRank)0;
            HandContents = HandDealt;
        }

        public bool HasOnePair()
        {
            return HandContents.Select(x => x.Rank).Distinct().Count() == 4;
        }
        public bool HasTwoPair()
        {
            return HandContents.GroupBy(x => x.Rank).Count() == 3 && HandContents.GroupBy(x => x.Rank).Any(x => x.Count() == 2);
        }
        public bool HasThreeKind()
        {
            return HandContents.GroupBy(x => x.Rank).Count() == 3 && HandContents.GroupBy(x => x.Rank).Any(x => x.Count() == 3);
        }
        public bool HasStraight()
        {
            return HandContents.Select(x => x.Rank).Distinct().Count() == 5 && (int)HandContents.OrderByDescending(x => x.Rank).First().Rank - (int)HandContents.OrderByDescending(x => x.Rank).Last().Rank == 4;
        }
        public bool HasFlush()
        {
            return HandContents.Select(x => x.Suit).Distinct().Count() == 1;
        }
        public bool HasFullHouse()
        {
            return HandContents.GroupBy(x => x.Rank).Count() == 2 && HandContents.GroupBy(x => x.Rank).Any(x => x.Count() == 3);
        }
        public bool HasFourKind()
        {
            return HandContents.GroupBy(x => x.Rank).Count() == 2 && HandContents.GroupBy(x => x.Rank).Any(x => x.Count() == 4);
        }
        public bool HasStraightFlush()
        {
            return HasStraight() && HasFlush();
        }
        public bool HasRoyalFlush()
        {
            return HasStraightFlush() && HandContents.Any(x => x.Rank == Rank.ace);
        }

        public void ShowHand()
        {
            if (HasRoyalFlush())
            {
                HandRank = (HandRank)9;
            }
            else if (HasStraightFlush())
            {
                HandRank = (HandRank)8;
            }
            else if (HasFourKind())
            {
                HandRank = (HandRank)7;
            }
            else if (HasFullHouse())
            {
                HandRank = (HandRank)6;
            }
            else if (HasFlush())
            {
                HandRank = (HandRank)5;
            }
            else if (HasStraight())
            {
                HandRank = (HandRank)4;
            }
            else if (HasThreeKind())
            {
                HandRank = (HandRank)3;
            }
            else if (HasTwoPair())
            {
                HandRank = (HandRank)2;
            }
            else if (HasOnePair())
            {
                HandRank = (HandRank)1;
            }

            foreach (Card c in HandContents.OrderByDescending(x => x.Rank).ThenBy(x => x.Suit))
            {
                Console.WriteLine(c.Rank + " of " + c.Suit);
            }
            Console.WriteLine();
            Console.WriteLine("==========Your Hand==========");
            Console.WriteLine();
            Console.WriteLine("          " + HandRank);
        }

        
    }
}
