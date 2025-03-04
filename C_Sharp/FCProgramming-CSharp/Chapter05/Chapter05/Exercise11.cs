using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
    class Exercise11
    {
        public void Execute()
        {
            Console.Write("Ingrese un número (0-999): ");
            int number = int.Parse(Console.ReadLine());

            string result = ConvertNumberToText(number);

            Console.WriteLine($"Número en texto: {result}");
        }

        static string ConvertNumberToText(int number)
        {
            if (number == 0)
                return "cero";

            string text = "";

            int hundreds = number / 100;
            int tensUnits = number % 100;

            switch (hundreds)
            {
                case 1: text = (tensUnits == 0) ? "cien" : "ciento"; break;
                case 2: text = "doscientos"; break;
                case 3: text = "trescientos"; break;
                case 4: text = "cuatrocientos"; break;
                case 5: text = "quinientos"; break;
                case 6: text = "seiscientos"; break;
                case 7: text = "setecientos"; break;
                case 8: text = "ochocientos"; break;
                case 9: text = "novecientos"; break;
            }

            if (tensUnits > 0)
            {
                if (text != "") text += " ";
                text += ConvertTens(tensUnits);
            }

            return text;
        }

        static string ConvertTens(int number)
        {
            switch (number)
            {
                case 1: return "uno";
                case 2: return "dos";
                case 3: return "tres";
                case 4: return "cuatro";
                case 5: return "cinco";
                case 6: return "seis";
                case 7: return "siete";
                case 8: return "ocho";
                case 9: return "nueve";
                case 10: return "diez";
                case 11: return "once";
                case 12: return "doce";
                case 13: return "trece";
                case 14: return "catorce";
                case 15: return "quince";
            }

            if (number < 30)
            {
                return "veinti" + ConvertTens(number - 20);
            }

            string tensText = "";
            int tens = number / 10;
            int units = number % 10;

            switch (tens)
            {
                case 3: tensText = "treinta"; break;
                case 4: tensText = "cuarenta"; break;
                case 5: tensText = "cincuenta"; break;
                case 6: tensText = "sesenta"; break;
                case 7: tensText = "setenta"; break;
                case 8: tensText = "ochenta"; break;
                case 9: tensText = "noventa"; break;
            }

            if (units > 0)
            {
                tensText += " y " + ConvertTens(units);
            }

            return tensText;
        }
    }
}
