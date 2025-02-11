using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
{
    internal class Exercise10
    {
        public void Execute()
        {
            Console.WriteLine("Give a 4 digit numbers: ");
            int number = int.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = (number % 10);

            int sum = a + b + c + d;
            Console.WriteLine($"Sum of digits: {a}+{b}+{c}+{d} = {sum}");
            Console.WriteLine($"Reverse order: {d}{c}{b}{a}");
            Console.WriteLine($"Last digit first position: {d}{a}{b}{c}");
            Console.WriteLine($"Second and third digits exchanged: {a}{c}{b}{d}");

        }
    }
}
