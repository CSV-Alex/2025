using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise07
    {
        public void Execute()
        {

            Console.WriteLine("Ingresa 5 numeros separados por un espacio: ");
            string input = Console.ReadLine();

            string[] inputPars = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputPars.Length != 5)
            {
                Console.WriteLine("Debes ingresar 5 numeros");
                return;
            }

            List<int> list = new List<int>();
            int suma = 0;

            for (int i = 0; i < inputPars.Length; i++)
            {
                int.TryParse(inputPars[i], out int number);
                list.Add(number);
            }

            for (int i = 0; i < list.Count; i++)
            {
                suma += list[i];
            }

            Console.WriteLine("La suma de los numeros es: {0}", suma);
        }
    }
}
