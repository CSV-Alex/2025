using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise06
    {
        public void Execute()
        {
            Console.Write("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;

            if (K > N)
            {
                Console.WriteLine("K must be smaller than N");
                return;
            }

            for (int i = 1; i <= N; i++)
            {
                factorialN *= i;
            }

            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
            }

            int result = factorialN / factorialK;
            Console.WriteLine("N! / K! = " + result);




        }
    }
}
