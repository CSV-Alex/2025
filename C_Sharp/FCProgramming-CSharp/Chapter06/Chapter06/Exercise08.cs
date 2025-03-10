using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise08
    {
        public void Execute()
        {
            Console.WriteLine("Catalan numbers, input N: ");
            int N = int.Parse(Console.ReadLine());

            if (N < 0)
            {
                Console.WriteLine("N must be a positive number");
                return;
            }
            // Fórmula
            int result = Factorial(2 * N) / (Factorial(N + 1) * Factorial(N));
            Console.WriteLine("Result:" + result);
        }

        public int Factorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
