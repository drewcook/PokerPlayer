using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BufferHeight = 10000;

            Deck myDeck = new Deck();

            Console.WriteLine("==========Welcome to the Poker Player 2k14!!!==========");
            Console.WriteLine();
            Console.WriteLine(@"In this game, you will be dealt a total of twenty hands.  Each hand will consist of five cards, each card with its own rank and suit.  There are 13 ranks (in order from lowest to highest): Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace.  There are 4 suits (order not important): Hearts, Diamonds, Clubs, Spades.  The game will let you know what kind hand you have in result of your five cards that are dealt.");
            Console.WriteLine();
            Console.WriteLine(@"For those of you that are not entirely familiar with how poker works, each hand has its own rank in the heiarchy of hands.  A High Card hand is the worst hand you can be dealt and a Royal Flush is the best hand you can be dealt.");
            Console.WriteLine();
            Console.WriteLine("======List of Hands=====");
            Console.WriteLine();
            Console.WriteLine("1.  High Card");
            Console.WriteLine("2.  One Pair");
            Console.WriteLine("3.  Two Pair");
            Console.WriteLine("4.  Three of a Kind");
            Console.WriteLine("5.  Straight");
            Console.WriteLine("6.  Flush");
            Console.WriteLine("7.  Full House");
            Console.WriteLine("8.  Four of a Kind");
            Console.WriteLine("9.  Straight Flush");
            Console.WriteLine("10. Royal Flush");
            Console.WriteLine();
            Console.WriteLine("Okay great!  Now you have a basic understanding of five card poker! Press any key to get dealing!!!");
            Console.WriteLine();
            Console.ReadKey(true);
            Console.Clear();

            PokerPlayer Drew = new PokerPlayer();

            for (int i = 0; i < 20; i++)
            {
                myDeck.Shuffle();
                Drew.DrawHand(myDeck.Deal(5));
                Console.WriteLine();
                Console.WriteLine("==========Your Cards==========");
                Console.WriteLine();
                Drew.ShowHand();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Press any key to deal again...");
                Console.ReadKey(true);
            }

            Console.Clear();
            Console.WriteLine("Well thats all there is to this simple poker game!  Thank you very much for playing Poker Player 2k14!!!");
            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey(true);

            //keep console open
            Console.ReadKey();
        }
    }
}
