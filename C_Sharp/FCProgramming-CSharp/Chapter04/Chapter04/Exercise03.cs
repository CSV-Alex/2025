using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
{
    internal class Exercise03
    {
        public void Execute()
        {
            Console.WriteLine("Enter company name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter company address:");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter company phone number:");
            int Phone_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company fax number:");
            int Fax_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter company web site:");
            string Web_site = Console.ReadLine();
            Console.WriteLine("Enter company manager:");
            string Manager = Console.ReadLine();

            Console.WriteLine("Company name: {0}", Name);
            Console.WriteLine("Company address: {0}", Address);
            Console.WriteLine("Company phone number: {0}", Phone_number);
            Console.WriteLine("Company fax number: {0}", Fax_number);
            Console.WriteLine("Company web site: {0}", Web_site);
            Console.WriteLine("Company manager: {0}", Manager);






        }
    }
}
