using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise04
    {
        public void Execute()
        {
            Console.WriteLine("All posible cards from a standart deck of 52 cards:");
            string[] suits = { "Diamonts", "Clubs", "Hearts", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10",
                               "Jack", "Queen", "King", "Ace" };

            for (int i = 0; i < ranks.Length; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    Console.WriteLine(ranks[i] + " of " + suits[j]);
                }
            }

        }
    }
}
