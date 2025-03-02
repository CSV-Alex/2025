using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise04
    {
        public void Execute()
        {
            Console.WriteLine("Enter three numbers: ");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine("...");

            int bigger = numberOne;
            int middle = numberTwo;
            int smaller = numberThree;
            Console.WriteLine("...");

            if (smaller > bigger)
            {
                int temp = bigger;
                bigger = smaller;
                smaller = temp;
            }
            else if (middle > bigger)
            {
                int temp = middle;
                middle = bigger;
                bigger = temp;
            }
            else if (smaller > middle)
            {
                int temp = middle;
                middle = smaller;
                smaller = temp;
            }

            Console.WriteLine("The New Order: ");
            Console.WriteLine($"{bigger}, {middle}, {smaller}");

        }
    }
}
