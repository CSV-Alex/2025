using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise03
    {
        public void Execute()
        {
            Console.WriteLine("Enter the first array of characters (without spaces): ");
            char[] firstArray = Console.ReadLine().ToCharArray();

            Console.WriteLine("Enter the second array of characters (without spaces): ");
            char[] secondArray = Console.ReadLine().ToCharArray();

            int minLength = Math.Min(firstArray.Length, secondArray.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine(firstArray[i] > secondArray[i] ? "First array is greater" : "Second array is greater");
                    return;
                }
            }

            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("First array is greater");
            }
            else if (firstArray.Length < secondArray.Length)
            {
                Console.WriteLine("Second array is greater");
            }
            else
            {
                Console.WriteLine("The arrays are equal");
            }
        }
    }
}
