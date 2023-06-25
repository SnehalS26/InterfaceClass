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

            Student_Total_Percentage st = new Student_Total_Percentage(70,80,79);
            st.Calculate();
            Console.WriteLine(st);

            /*============================================================*/
            //StudentData stud = new StudentData();
            //stud.roll_no = 1;  // call to set accessor
            //stud.name = "snehal";
            //stud.percentage = 87.80;
            //Console.WriteLine(stud.PrintDetails());
            

            /*===========================================================================*/
            //Discount d = new Discount(101, "Enega", 200, 0.5);
            //d.Calculate();
            //d.Display();
            //Console.WriteLine(d.Display());
            /*========================================================================*/


            //Inheritance i = new Inheritance("snehal" , 2000);
            //i.CalculateSalary();
            //Console.WriteLine(i.PrintDetails());

            //SalesManager s = new SalesManager("sneh", 3000, 30);
            //s.CalculateSalary();
            //Console.WriteLine(i.PrintDetails());


        }
    }
}
