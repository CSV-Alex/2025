using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise11
    {
        public void Execute() 
        { 
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            int divisor = 5;
            long factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            do
            {
                count += number / divisor;
                divisor *= 5;
            } 
            while (number / divisor > 0);

            Console.WriteLine("Factorial: " + factorial);
            Console.WriteLine("Trailing zeros: " + count);
        }
    }
}
