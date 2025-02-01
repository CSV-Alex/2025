using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu nombre de iure: ");
            string Nombre = Console.ReadLine();

            Console.Write("Ingresa tu sueldo: ");
            int Sueldo = int.Parse(Console.ReadLine());

            if (Sueldo <= 1024)
            {
                Console.WriteLine("Eres pobre");
            }
            else if (Sueldo <= 2048)
            {
                Console.WriteLine("Eres clase media");
            }

            else if (Sueldo <= 4096)
            {
                Console.WriteLine("Eres clase alta");
            }
            else
            {
                Console.WriteLine("Eres un magnate");
            }

        }
    }
}
