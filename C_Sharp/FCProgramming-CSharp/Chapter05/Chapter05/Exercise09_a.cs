using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise09_a
    {
        public void Execute()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{i + 1}. Enter the number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int size = 1; size <= 4; size++)
            {
                SubSets(numbers, size);
            }
        }

        static void SubSets(int[] numbers, int size)
        {
            List<int> subset = new List<int>();

            void Generate(int start, int depth)
            {
                if (depth == size)
                {
                    if (subset.Sum() == 0)
                        Console.WriteLine($"Subset: {string.Join(", ", subset)}");
                    return;
                }

                for (int i = start; i < numbers.Length; i++)
                {
                    subset.Add(numbers[i]);
                    Generate(i + 1, depth + 1);
                    subset.RemoveAt(subset.Count - 1);
                }
            }

            Generate(0, 0);
        }
    }
}
