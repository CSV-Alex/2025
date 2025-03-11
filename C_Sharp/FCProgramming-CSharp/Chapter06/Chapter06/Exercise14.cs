using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise14
    {
        public void Execute()
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string hexadecimalNumber = "";
            int number = decimalNumber;

            if (number == 0)
            {
                hexadecimalNumber = "0";
            }
            else
            {
                while (number > 0)
                {
                    int remainder = number % 16;
                    if (remainder < 10)
                    {
                        hexadecimalNumber = remainder + hexadecimalNumber;
                    }
                    else
                    {
                        hexadecimalNumber = (char)(remainder - 10 + 'A') + hexadecimalNumber;
                    }
                    number /= 16;
                }
            }

            Console.WriteLine("Hexadecimal representation: " + hexadecimalNumber);
        }
    }
}
