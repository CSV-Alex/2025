using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise01
    {
        public void Execute()
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
