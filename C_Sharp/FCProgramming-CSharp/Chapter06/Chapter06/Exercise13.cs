using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise13
    {
        public void Execute()
        {
            Console.Write("Enter a binary number: ");
            string binaryNumber = Console.ReadLine();

            int decimalNumber = 0;
            int length = binaryNumber.Length;

            for (int i = 0; i < length; i++)
            {
                if (binaryNumber[length - 1 - i] == '1')
                {
                    decimalNumber += (int)Math.Pow(2, i);
                }
            }

            Console.WriteLine("Decimal representation: " + decimalNumber);
        }
    }
}
