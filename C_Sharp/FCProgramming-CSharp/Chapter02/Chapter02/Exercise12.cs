
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
{
    internal class Exercise12
    {
        // Name, Lastname, Age, Gender ("m" or "f"), Unique Employee number (27560000-27569999).
        // Declare appropriate variables needed
        public void Execute()
        {
            string Name;
            string LastName;
            byte Age;
            int PersonalID;
            char Gender = '\0'; // Initialize Gender to avoid CS0165

            Console.WriteLine("Enter your Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter your Last Name: ");
            LastName = Console.ReadLine();
            Console.WriteLine("Enter your Age: ");
            Age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter your ID: (27560000-27569999)");
            PersonalID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your gender (m/f): ");

            bool validGender = false;
            while (!validGender)
            {
                if (char.TryParse(Console.ReadLine(), out Gender) && (Gender == 'm' || Gender == 'f'))
                {
                    validGender = true;
                }
                else
                {
                    Console.WriteLine("Invalid gender, try again with m or f");
                }
            }

            Console.WriteLine("Name: {0} {1}", Name, LastName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Personal ID: {0}", PersonalID);
            if (Gender == 'm')
            {
                Console.WriteLine("Masculine");
            }
            else
            {
                Console.WriteLine("Feminine");
            }
        }
    }
}
