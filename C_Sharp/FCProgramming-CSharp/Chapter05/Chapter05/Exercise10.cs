using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise10
    {
        public void Execute()
        {
            Console.WriteLine("Enter a number (1-9): ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1 && number <= 3)
            {
                Console.Write($"{number} with score X10: {number * 10}");
            }
            else if (number >= 4 && number <= 6)
            {
                Console.Write($"{number} with score X100: {number * 100}");
            }
            else if (number >= 7 && number <= 9)
            {
                Console.Write($"{number} with score X1000: {number * 1000}");
            }
            else
            {
                Console.Write("Invalid number");
                Execute();
            }
        }
    }
}
