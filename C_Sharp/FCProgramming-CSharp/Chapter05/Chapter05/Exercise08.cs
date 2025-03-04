using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise08
    {
        public void Execute()
        {
            Console.WriteLine("Select a option: ");
            Console.WriteLine("0. int");
            Console.WriteLine("1. double");
            Console.WriteLine("2. string");

            Console.WriteLine("-------------------------------------------");

            int option = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------");

            switch (option)
            {
                case 0:
                    Console.WriteLine("Enter a number: ");
                    int intNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine($"The number is: {intNumber} + 1: {++intNumber}");
                    break;
                case 1:
                    Console.WriteLine("Enter a number: ");
                    double doubleNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"The number is: {doubleNumber.ToString("F1")} + 1: {(doubleNumber + 1).ToString("F1")}");
                    break;
                case 2:
                    Console.WriteLine("Enter a string: ");
                    string stringText = Console.ReadLine();
                    Console.WriteLine($"The text is: {stringText}*");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

        }
    }
}
