using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    class Exercise12
    {
        public void Execute()
        {
            double sum = 0;
            double baseNumber = 1;

            for (int i = 1; i <= 5; i++)
            {
                sum += 1/ baseNumber;
                baseNumber++;
            }

            Console.WriteLine($"The sum of the series is: {sum}");
        }
    }
}
