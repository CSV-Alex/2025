﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int Dia;
            Console.Write("Ingrese el dia en formato numerico: ");
            Dia = int.Parse(Console.ReadLine());

            switch(Dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Ingrese un dia valido, porfavor");
                    break;
            

            }
            */

            // ESTRUCTURA CICLICA DO-WHILE
            /*
            int Numero;
            Numero = 1;

            do
            {
                Console.WriteLine("Numero: " + Numero);
                Numero++;
            } while (Numero < 11);
            Console.ReadKey();
            */

            // ESTRUCTURA CICLICA WHILE

            int Correlativo;
            Correlativo = 0;
            Console.WriteLine("La tabla del 5");

            while (Correlativo <= 12)
            {
                Console.WriteLine(Correlativo + " x 5 = " + Correlativo * 5);
                Correlativo++;
            }
        }
    }
}
