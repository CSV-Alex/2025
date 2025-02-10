using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise02
    {
        public void Execute()
        {
            bool isDivisible = false;
            int number;
            Console.Write("Enter a number: ");

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if ((number % 5 == 0) && (number % 7 == 0))
                {
                    isDivisible = true;
                }

                if (isDivisible)
                {
                    Console.WriteLine("The number {0} is divisable by both 5 and 7", number);
                }
                else
                {
                    Console.WriteLine("The number {0} is not divisable by both 5 and 7", number);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }


        }
    }
}
