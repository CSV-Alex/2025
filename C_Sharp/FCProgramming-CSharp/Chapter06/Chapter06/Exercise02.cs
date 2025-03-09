using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise02
    {
        public void Execute()
        {
            //Not divisible for 3 and 7 simutaneously
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % (3*7) != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
