using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise09
    {
        public void Execute()
        {
            Console.WriteLine("Give two numbers for the coordinates: ");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double[] circleCoordinates = new double[] { 0.0, 0.0 };
            double radius = 5.0;
            
            double distance = Math.Sqrt(Math.Pow(x - circleCoordinates[0], 2) + Math.Pow(y - circleCoordinates[1], 2));
            
            double[] rectangleLowerLeft = new double[] { -1.0, 1.0 }; // Lower-left corner
            double[] rectangleUpperRight = new double[] { 5.0, 5.0 }; // Upper-right corner

            if (distance < radius)
            {
                Console.WriteLine("The point is inside the circle.");
                Console.WriteLine(distance);
            }
            else if (distance > radius)
            {
                Console.WriteLine("The point is outside the circle.");
                Console.WriteLine(distance);
            }
            else
            {
                Console.WriteLine("The point is on the circle.");
                Console.WriteLine(distance);
            }

            if (x >= rectangleLowerLeft[0] && x <= rectangleUpperRight[0] && 
                y >= rectangleLowerLeft[1] && y <= rectangleUpperRight[1])
            {
                Console.WriteLine("The point is inside the rectangle.");
            }
            else if (x <= rectangleLowerLeft[0] || x >= rectangleUpperRight[0] || 
                     y <= rectangleLowerLeft[1] || y >= rectangleUpperRight[1])
            {
                Console.WriteLine("The point is outside the rectangle.");
            } 
            else
            {
                Console.WriteLine("The point is on the rectangle.");
            }
        }
    }
}
