using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise10
    {
        public void Execute()
        {
            Console.Write("Enter a number: ");  
            int number = int.Parse(Console.ReadLine());

            if (number > 20)
            {
                Console.WriteLine("Number must be less than or equal to 20.");
                return;
            }
            
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < number; i++)
            {   
                for (int j = 1; j <= number; j++)
                {
                    Console.Write((j + i) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
