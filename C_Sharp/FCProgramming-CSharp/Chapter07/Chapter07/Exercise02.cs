using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise02
    {
        public void Execute()
        {
            Console.WriteLine("Enter names separated by space:");
            string[] names = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter names to compare separated by space:");
            string[] compareNames = Console.ReadLine().Split(' ');

            if (names.Length != compareNames.Length)
            {
                Console.WriteLine("Arrays are not equal");
                return;
            }

            bool areEqual = true;
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] != compareNames[i] && areEqual != false)
                {
                    Console.WriteLine("Array {0} are not equal in index", names[i]);
                    areEqual = false;
                }
                else
                {
                    Console.WriteLine("Arrays {0} are equal on index", compareNames[i]);
                }
            }

            if (areEqual)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Arrays are equal and have the same index");
            }
            else
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Arrays are NOT equal and have different index");
            }
        }
    }
}
