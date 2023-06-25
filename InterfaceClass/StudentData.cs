using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Create class Student, with roll no , name , percentage auto implemented properties.
//Use property initialize syntax to assign the values. Print the student details
namespace InterfaceClass
{
    public class StudentData
    {
       
       
        public int roll_no { get; set; }
        public string name { get; set; }
        public double percentage { get; set; }

       
        
        public string PrintDetails()
        {
            return $"Roll No. = {roll_no} \nStudent Name = {name} \nPercentage = {percentage}";
        }
    }
}
