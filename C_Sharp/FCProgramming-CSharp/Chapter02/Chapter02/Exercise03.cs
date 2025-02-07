using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise03
    {
        // Compares correctly two real numbers with accuracy at least 0.000001

        public void Execute ()
        {
            double a = 1.000000000000000012;
            double b = 1.000000000000000013;

            if (a > b)
            {
                Console.WriteLine("Failed");
            } else if (a == b) 
            {
                Console.WriteLine("Completed");
            }
        }

    }
}
