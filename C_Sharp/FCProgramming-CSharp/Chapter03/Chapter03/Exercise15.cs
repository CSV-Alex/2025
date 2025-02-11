using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise15
    {
        public void Execute()
        {
            Console.Write("Enter a 32-bit unsigned integer: ");
            uint number = uint.Parse(Console.ReadLine());


            uint bits3to5 = (number >> 3) & 0x7;
            uint bits24to26 = (number >> 24) & 0x7;


            number &= ~(0x7u << 3);  // Clear bits
            number &= ~(0x7u << 24); 

            number |= (bits24to26 << 3);
            number |= (bits3to5 << 24);

            Console.WriteLine($"Original number: {Convert.ToString(number, 2).PadLeft(32, '0')}");
            Console.WriteLine($"Modified number: {Convert.ToString(number, 2).PadLeft(32, '0')}");
            Console.WriteLine($"Modified number (decimal): {number}");
        }
    }
}
