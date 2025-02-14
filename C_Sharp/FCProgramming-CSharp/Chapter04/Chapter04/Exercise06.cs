using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise06
    {
        public void Execute()
        {
            Console.WriteLine("Enter two numbers: ");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Greater: {0}", + Math.Max(a, b));
            Console.WriteLine("Smaller: {0}", +Math.Min(a, b));
        }
    }
}
