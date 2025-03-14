using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise04
    {
        public void Execute()
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter numbers separated by spaces: ");
            string input = Console.ReadLine();

            string[] inputNumbers = input.Split(' ');

            foreach (string number in inputNumbers)
            {
                if (int.TryParse(number, out int parsedNum))
                {
                    numbers.Add(parsedNum);
                }
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("No numbers entered.");
                return;
            }

            int current = numbers[0];
            int count = 1;
            int maxCount = 1;
            int numberMayor = numbers[0];

            for (int i = 1; i < numbers.Count; i++)
            {
                if (current == numbers[i])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                        numberMayor = current;
                    }
                }
                else
                {
                    current = numbers[i];
                    count = 1;
                }
            }

            Console.WriteLine($"The longest sequence of consecutive equal numbers has {maxCount} elements.");
            Console.WriteLine($"The number that repeats the most in this sequence is: {numberMayor}");
        }
    }
}
