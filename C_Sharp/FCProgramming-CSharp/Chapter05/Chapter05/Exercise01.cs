using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise01
    {
        public void Execute()
        {
            // Write an if-statement that takes two integer variables and exchanges
            // their values if the first one is greater than the second one.

            int a = 5;
            int b = 10;

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            else
            {
                Console.WriteLine("a is not greater than b");
            }
        }
    }
}
