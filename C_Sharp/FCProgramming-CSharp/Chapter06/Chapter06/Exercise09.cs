using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise09
    {
        public void Execute()
        {
            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            int factorial = 1;
            int power = 1;
            double sum = 0;

            if (N < 0)
            {
                Console.WriteLine("N must be non-negative.");
                return;
            }

            if (X == 0 && N > 0)
            {
                Console.WriteLine("X must be non-zero if N > 0.");
                return;
            }

            for (int i = 0; i <= N; i++) {
                if (i > 0)
                {
                    factorial *= i;
                    power *= X;
                }
                sum += (double)factorial / power;
            }
            Console.WriteLine("Result: " + sum);
        }
    }
}
