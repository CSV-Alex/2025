using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise02
    {
        public void Execute()
        {
            Console.WriteLine("The product of three numbers");
            Console.WriteLine("Enter three numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int negativeCounter = 0;

            if (a < 0)
            {
                negativeCounter++;
            }

            if (b < 0)
            {
                negativeCounter++;
            }

            if (c < 0)
            {
                negativeCounter++;
            }

            if (negativeCounter % 2 == 0)
            {
                Console.WriteLine("The product of the three numbers is: " + a * b * c);
                Console.WriteLine("The number of negative numbers is: " + negativeCounter);
                Console.WriteLine("And the sign is +");
            }
            else
            {
                Console.WriteLine("The product of the three numbers is: " + a * b * c);
                Console.WriteLine("The number of negative numbers is: " + negativeCounter);
                Console.WriteLine("And the sign is -");

            }
        }
    }
}
