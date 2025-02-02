using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intruccion_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nentero = 0;
            Console.WriteLine("Ingrese un numero entero para la tabla de suma: ");
            Nentero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i + " + " + Nentero + " = " + (i + Nentero));
            }

        }
    }
}
