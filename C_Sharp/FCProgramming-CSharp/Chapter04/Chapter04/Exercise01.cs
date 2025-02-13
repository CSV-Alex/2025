using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise01
    {
        public void Execute()
        {
            Console.WriteLine("Enter 3 numbers please: ");
            Console.Write("Number A: ");
            int numberA = Int32.Parse(Console.ReadLine());
            Console.Write("Number B: ");
            int numberB = Int32.Parse(Console.ReadLine());
            Console.Write("Number C: ");
            int numberC = Int32.Parse(Console.ReadLine());
            Console.WriteLine("The sum of the numbers is: " + (numberA + numberB + numberC));
        }
    }
}
