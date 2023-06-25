using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfaceClass
{
    internal class Student_Total_Percentage
    {
        
        public int marathi, hindi, english;
        public double total_marks, percentage;

        public Student_Total_Percentage(int marathi, int hindi, int english)
        {
            this.marathi = marathi;
            this.hindi = hindi;
            this.english = english;
        }
        public void Calculate()
        {
            total_marks = marathi + hindi + english;
            percentage = (total_marks / 300) * 100;
        }

        public override string ToString()
        {
            return $"Toatal Marks = {total_marks} \nPercentage = {percentage}";
        }
    }
}
