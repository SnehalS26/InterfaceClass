using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inheritance i = new Inheritance("snhehal" , 2000);
            i.CalculateSalary();
            Console.WriteLine(i.PrintDetails());

        }
    }
}
