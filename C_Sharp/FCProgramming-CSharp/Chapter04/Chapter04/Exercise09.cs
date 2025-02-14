using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise09
    {
        public void Execute()
        {
            Console.WriteLine("Enter 'n' numbers, print 'S' for sum: ");
            string input = Console.ReadLine();
            int sum = 0;
            while (input != "S")
            {
                sum += int.Parse(input);
                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
