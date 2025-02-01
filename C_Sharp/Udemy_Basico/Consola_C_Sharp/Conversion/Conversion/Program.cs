using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            int Edad;
            bool Casado;
            double Sueldo;

            Console.Write("Ingrese su nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Ingrese su Edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.Write("Eres Casado ?: ");
            Casado = bool.Parse(Console.ReadLine());

            Console.Write("Ingrese su Sueldo: ");
            Sueldo = double.Parse(Console.ReadLine());


        }
    }
}
