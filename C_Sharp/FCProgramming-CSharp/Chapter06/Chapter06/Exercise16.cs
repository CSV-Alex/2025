using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise16
    {
        public void Execute()
        {
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                numbers.Add(i);
            }

            Random rng = new Random();
            int n = numbers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = numbers[k];
                numbers[k] = numbers[n];
                numbers[n] = value;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
