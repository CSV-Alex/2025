using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise05
    {
        public void Execute()
        {
            List<int> arr = new List<int>();
            string[] strings = Console.ReadLine().Split(' ');

            for (int i = 0; i < strings.Length; i++)
            {
                if (int.TryParse(strings[i], out int number))
                {
                    arr.Add(number);
                }
            }

            List<int> result = FindMaxIncreasingSequence(arr);

            Console.WriteLine("Maximal increasing sequence: {" + string.Join(", ", result) + "}");
        }

        static List<int> FindMaxIncreasingSequence(List<int> arr)
        {
            if (arr == null || arr.Count == 0)
                return new List<int>();

            List<int> maxSequence = new List<int> { arr[0] };
            List<int> currentSequence = new List<int> { arr[0] };

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] > currentSequence[currentSequence.Count - 1])
                {
                    currentSequence.Add(arr[i]);
                }
                else
                {
                    if (currentSequence.Count > maxSequence.Count)
                    {
                        maxSequence = new List<int>(currentSequence);
                    }
                    currentSequence = new List<int> { arr[i] };
                }
            }

            if (currentSequence.Count > maxSequence.Count)
            {
                maxSequence = new List<int>(currentSequence);
            }

            return maxSequence;
        }
    }
}
