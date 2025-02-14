using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise10
    {
        public void Execute()
        {

            Console.Write("Enter a number: ");
            int Number = int.Parse(Console.ReadLine());
            int Counter = 1;

            while (Counter != Number)
            {
                Console.WriteLine(Counter); Counter++;
            }
            Console.WriteLine(Number);

        }
    }
}
