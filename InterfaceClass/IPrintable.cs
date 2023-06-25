using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * 1.	Create class Employee. Add fields like id, name, basic salary, HRA, TA, PF. Accept the value of id, name & basic salary from constructor. Calculate the employee gross salary  & display employee details using ToString() method
a.	HRA- 40% of basic salary
b.	TA – 20% of basic salary
c.	PF -12 % of basic salary
*/
namespace InterfaceClass
{
    public interface IPrintable
    {
        string PrintDetails();
    }
    public class Inheritance : IPrintable
    {
        protected int empid;
        protected string name;
        protected double basicSal, totalSal, grossSal, hra, ta, da, pf;
        private static int count;

        public Inheritance(string name, double basicSal)
        {
            count++;
            empid = count;
            this.name = name;
            this.basicSal = basicSal;
        }

        public static int GetCount()
        {
            return count;
        }

        public virtual void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }

        public string PrintDetails()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }

    public class SalesManager : Inheritance , IPrintable
    {
        private double comm;
        //first always call base class constructor
        public SalesManager(string name, double basicSal, double comm) : base(name, basicSal)
        {
            this.comm = comm;
        }

        public override void CalculateSalary()
        {
            hra = basicSal * 0.40;
            ta = basicSal * 0.20;
            da = basicSal * 0.15;
            pf = basicSal * 0.12;

            totalSal = hra + ta + da;

            grossSal = (hra + ta + da + comm) - pf;
        }
        public override string ToString()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
        public string PrintDetails()
        {
            return $"id = {empid} \nName = {name} \nGross = {grossSal}";
        }
    }


}
