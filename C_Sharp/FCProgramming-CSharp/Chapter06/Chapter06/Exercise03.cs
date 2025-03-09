using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise03
    {
        public void Execute() 
        {
            Console.WriteLine("Enter a series of numbers");
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int smallest = numbers[0];
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
                if (numbers[i] > largest)
                {
                    largest = numbers[i];
                }
            }

            Console.WriteLine("The smallest number is: " + smallest);
            Console.WriteLine("The largest number is: " + largest);
        }
    }
}
