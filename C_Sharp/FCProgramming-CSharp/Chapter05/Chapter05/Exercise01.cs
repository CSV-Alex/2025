using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise01
    {
        public void Execute()
        {
            Console.WriteLine("Enter two numbers: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
                Console.WriteLine("---------------------------");
                Console.WriteLine("Higher number is b (switching): " + b);
                Console.WriteLine("And now 'a' number is : " + a);
            }
            else
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("a is not greater than b");
                Console.WriteLine("Not switching variables");
                Console.WriteLine("a: " + a);
                Console.WriteLine("b: " + b);
            }
        }
    }
}
