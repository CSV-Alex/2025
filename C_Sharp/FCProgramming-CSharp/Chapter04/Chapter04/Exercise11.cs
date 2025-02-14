using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    class Exercise11
    {
        public void Execute()
        {
            Console.WriteLine("Enter the cantity limit number: ");
            int n = int.Parse(Console.ReadLine());
            int prev = 0;
            int next = 1;

            if (n < 0)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            
            if (n == 0)
            {
                Console.WriteLine("You choose 0 numbers to be displayed");
            }
            else if (n == 1)
            {
                Console.WriteLine(prev);
            }
            else
            {
                Console.WriteLine("The first " + n + " numbers of the Fibonacci sequence are: ");
                for (int i = 0; i < n; i++)
                {

                    Console.WriteLine(prev);
                    int temp = prev;
                    prev = next;
                    next = temp + next;

                }
            }

        }

    }
}
