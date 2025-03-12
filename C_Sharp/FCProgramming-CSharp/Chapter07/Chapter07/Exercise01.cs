using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
{
    class Exercise01
    {
        public void Execute()
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i] * 5);
            }
        }
    }
}
