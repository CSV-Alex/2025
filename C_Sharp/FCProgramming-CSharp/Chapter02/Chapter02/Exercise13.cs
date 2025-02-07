using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise13
    {
        public void Execute()
        {
            int number1 = 5;
            int number2 = 10;

            Console.WriteLine("Before swap: number1 = {0}, number2 = {1}", number1, number2);
            int temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("After swap: number1 = {0}, number2 = {1}", number1, number2);
        }
    }
}
