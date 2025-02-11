using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise14
    {
        public void Execute()
        {
            Console.WriteLine("Its your number a prime number?");
            Console.Write("Give a number (1 < n < 100): ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (number < 100 && number > 1)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine("The number is not a prime number.");
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("The number is a prime number.");
                }
            } 
            else
            {
                Console.WriteLine("The number is out of the range (1 - 100)");
            }
        }
    }
}
