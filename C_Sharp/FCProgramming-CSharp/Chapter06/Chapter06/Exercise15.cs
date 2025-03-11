using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise15
    {
        public void Execute()
        {
            Console.Write("Enter a hexadecimal number: ");
            string hexadecimalNumber = Console.ReadLine();

            int decimalNumber = 0;
            int length = hexadecimalNumber.Length;

            for (int i = 0; i < length; i++)
            {
                char currentChar = hexadecimalNumber[length - 1 - i];
                int value;

                if (currentChar >= '0' && currentChar <= '9')
                {
                    value = currentChar - '0';
                }
                else if (currentChar >= 'A' && currentChar <= 'F')
                {
                    value = currentChar - 'A' + 10;
                }
                else if (currentChar >= 'a' && currentChar <= 'f')
                {
                    value = currentChar - 'a' + 10;
                }
                else
                {
                    Console.WriteLine("Invalid hexadecimal number.");
                    return;
                }

                decimalNumber += value * (int)Math.Pow(16, i);
            }

            Console.WriteLine("Decimal representation: " + decimalNumber);
        }
    }
}
