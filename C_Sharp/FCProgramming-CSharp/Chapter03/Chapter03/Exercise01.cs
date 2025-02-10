using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise01
    {
        public void Execute()
        {
            int number;
            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else if (number % 2 != 0)
                {
                    Console.WriteLine("The number is odd.");
                }
                else
                {
                    Console.WriteLine("The number is zero.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
