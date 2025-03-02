using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise03
    {
        public void Execute()
        {
            Console.WriteLine("Enter three numbers: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());
            Console.WriteLine("Finding the bigger...");

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                Console.WriteLine($"The bigger number is {numberOne}");
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                Console.WriteLine($"The bigger number is {numberTwo}");
            }
            else
            {
                Console.WriteLine($"The bigger number is {numberThree}");
            }
        }
    }
}
