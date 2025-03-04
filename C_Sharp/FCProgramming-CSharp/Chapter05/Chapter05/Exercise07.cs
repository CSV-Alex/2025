using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise07
    {
        public void Execute()
        {
            Console.WriteLine("Give 5 numbers: ");
            int[] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Number {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int higger = numbers[0];
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] > higger)
                {
                    higger = numbers[i];
                }
            }

            Console.WriteLine("The higger number is: {0}", higger);
        }
    }
}
