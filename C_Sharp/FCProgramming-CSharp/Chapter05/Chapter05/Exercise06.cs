using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise06
    {
        public void Execute()
        {

            Console.WriteLine("Enter the coeficients a, b and c of a quadratic equation ax^2 + bx + c = 0");
            Console.Write("a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c: ");
            double c = double.Parse(Console.ReadLine());

            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                Console.WriteLine("The equation has no real roots.");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("The equation has one real root: {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("The equation has two real roots: {0} and {1}", x1, x2);
            }

        }

    }
}
