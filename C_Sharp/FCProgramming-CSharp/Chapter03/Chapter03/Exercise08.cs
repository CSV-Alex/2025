using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise08
    {
        public void Execute()
        {
            Console.WriteLine("Give two numbers for the coordinates: ");
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double[] coordinates = new double[] { 0.0, 0.0 };
            double radius = 5.0;
            double distance = Math.Sqrt(Math.Pow(number1 - coordinates[0], 2) + Math.Pow(number2 - coordinates[1], 2));

            if (distance < radius)
            {
                Console.WriteLine("The point is inside the circle.");
                Console.WriteLine(distance);
            } else if (distance > radius)
            {
                Console.WriteLine("The point is outside the circle.");
                Console.WriteLine(distance);
            } else
            {
                Console.WriteLine("The point is on the circle.");
                Console.WriteLine(distance);
            }
        }
    }
}
