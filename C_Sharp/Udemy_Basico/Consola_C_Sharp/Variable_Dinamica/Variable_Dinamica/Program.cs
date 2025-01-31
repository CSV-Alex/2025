using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Dinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The variable can be assigned a different type of value
            dynamic variableDinamica = 10;
            Console.WriteLine(variableDinamica);
            variableDinamica = "Hola Mundo";
            Console.WriteLine(variableDinamica);
            variableDinamica = new { Nombre = "Juan", Edad = 20 };
            Console.WriteLine(variableDinamica.Nombre);
            Console.WriteLine(variableDinamica.Edad);
            Console.ReadKey();
        }
    }
}
