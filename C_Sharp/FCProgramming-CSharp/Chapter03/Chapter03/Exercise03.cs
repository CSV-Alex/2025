using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise03
    {
        public void Execute()
        {
            int number;
            Console.Write("Enter a number with 3 digits: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number / 100 != 0 || number == 100)
                {
                    number /= 100;
                    if (number == 7)
                    {
                        Console.WriteLine("The third digit is 7 (right to left)");
                    }
                    else
                    {
                        Console.WriteLine("The third digit is not 7 (right to left)");
                    }
                } else
                {
                    Console.WriteLine("The number is not 3 digits long.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

        }
    }
}
