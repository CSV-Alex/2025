using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise17
    {
        public void Execute() 
        { 
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int b = int.Parse(Console.ReadLine());

            int numerator = Math.Abs(a*b);

            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            int GCD = a;
            int LCM = numerator / GCD;

            Console.WriteLine("GCD: " + GCD);
            Console.WriteLine("LCM: " + LCM);
        }
    }
}
