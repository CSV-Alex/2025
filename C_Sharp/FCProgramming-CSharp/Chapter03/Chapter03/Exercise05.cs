using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise05
    {
        public void Execute()
        {
            Console.WriteLine("Trapezoid area calculator: ");
            Console.WriteLine("Enter the length of the first base: ");
            double firstBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of the second base: ");
            double secondBase = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height: ");
            double height = double.Parse(Console.ReadLine());
            double area = (firstBase + secondBase) * height / 2;
            Console.WriteLine($"The area of the trapezoid is {area}");
        }
            
    }
}
