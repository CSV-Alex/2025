using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    class Exercise12
    {
        public void Execute()
        {
            Console.Write("Enter a decimal number: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            string binaryNumber = DecimalToBinary(decimalNumber);

            Console.WriteLine("Binary representation: " + binaryNumber);
        }

        static string DecimalToBinary(int number)
        {
            if (number == 0)
            {
                return "0";
            }

            string binary = "";

            while (number > 0)
            {
                int remainder = number % 2;
                binary = remainder + binary;
                number /= 2;
            }

            return binary;
        }
    }
}
