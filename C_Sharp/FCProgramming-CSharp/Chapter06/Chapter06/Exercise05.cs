using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise05
    {
        public void Execute()
        {
            Console.Write("Enter the N number for Fibonacci: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------------");
            int start = 0;
            int next = 1;

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(start);
                int temp = start;
                start = next;
                next = temp + next;
            }
        }
    }
}
