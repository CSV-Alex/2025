using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise02
    {
        public void Execute()
        {
            Console.WriteLine("Enter the radius r of a circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine("The area of the circle is: " + area);
            Console.WriteLine("The perimeter of the circle is: " + perimeter);
        }
    }
}
