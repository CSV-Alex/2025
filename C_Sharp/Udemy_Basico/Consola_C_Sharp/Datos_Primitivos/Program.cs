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

            Console.Write("Cuál es tu nombre?: ");
            nombre = Console.ReadLine();

            Console.Write("Cuál es tu edad?: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa tu sueldo: ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Casado?: ");
            casado = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Tu nombre es: " + nombre + " y tu edad es: " + edad);
            Console.WriteLine("Tu sueldo es: " + sueldo + " y tu consulta de casado es: " + casado);
            Console.ReadKey();
        }
    }
}
