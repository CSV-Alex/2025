using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Primitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;
            double sueldo;
            bool casado;

            edad = 10;
            nombre = "Victor";
            sueldo = 100.50;
            casado = true;

            Console.WriteLine("Edad es: " + edad);
            Console.WriteLine("Nombre es: " + nombre);
            Console.WriteLine("Sueldo es: " + sueldo);
            Console.WriteLine("Estado civil es: " + casado);
            Console.ReadKey();
        }
    }
}
