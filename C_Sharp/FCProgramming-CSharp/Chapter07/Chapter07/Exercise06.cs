using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise06
    {
        public void Execute()
        {
            Console.WriteLine("Enter a sequence of numbers separated by spaces:");
            string input = Console.ReadLine();
            string[] strings = input.Split(' ');

            List<int> arr = new List<int>();
            foreach (string s in strings)
            {
                if (int.TryParse(s, out int number))
                {
                    arr.Add(number);
                }
            }

            List<int> result = FindLongestIncreasingSubsequence(arr.ToArray());

            Console.WriteLine("Longest increasing subsequence: {" + string.Join(", ", result) + "}");
        }

        static List<int> FindLongestIncreasingSubsequence(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return new List<int>();

            int n = arr.Length;
            int[] dp = new int[n];
            int[] prev = new int[n];
            for (int i = 0; i < n; i++)
            {
                dp[i] = 1;
                prev[i] = -1;
            }

            int maxLength = 1, maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] < arr[i] && dp[j] + 1 > dp[i])
                    {
                        dp[i] = dp[j] + 1;
                        prev[i] = j;
                    }
                }
                if (dp[i] > maxLength)
                {
                    maxLength = dp[i];
                    maxIndex = i;
                }
            }

            List<int> sequence = new List<int>();
            for (int i = maxIndex; i >= 0; i = prev[i])
            {
                sequence.Add(arr[i]);
                if (prev[i] == -1)
                    break;
            }

            sequence.Reverse();
            return sequence;
        }
    }
}
