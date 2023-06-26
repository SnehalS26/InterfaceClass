using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public interface IPrint
    {
        string PrintD();
    }

    abstract public class Shape
    {
        public abstract void CalculateArea();
    }

    public class Circle : Shape, IPrint
    {
        private int r;
        private double area;
        public Circle(int r)
        {
            this.r = r;
        }
        public override void CalculateArea()
        {
            area = 3.14 * r * r;
        }
        public string PrintD()
        {
            return $"Area Of Circle = {area}";
        }

        public override string ToString()
        {
            return $"Area Of Circle = {area}";
        }
    }

    public class Rectangle : Shape, IPrint
    {
        private int l, b;
        private double area;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public override void CalculateArea()
        {
            area = l * b;
        }

        public string PrintD()
        {
            return $"Area of Reactangle = {area}";
        }

        public override string ToString()
        {
            return $"Area of Reactangle = {area}";
        }
    }
}

