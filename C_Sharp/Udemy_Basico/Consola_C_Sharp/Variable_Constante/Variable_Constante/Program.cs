using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Constante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int edad;
            const double sueldo = 12000;

            nombre = "Victor";
            edad = 25; 
            Console.WriteLine("Sueldo actual: " + sueldo);

            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.ReadKey();
        }
    }
}
