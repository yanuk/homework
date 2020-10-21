using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Essential1_1
{
    public class Rectangle
    {
        private double side1, side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public double PerimeterCalculator()
        {
            return (2 * (this.side1 + this.side2));
        }
        public double AreaCalculator()
        {
            return (this.side1 * this.side2);
        }

        public double Perimetr
        {
            get
            {
                return (this.PerimeterCalculator());
            }
        }
        public double Area
        {
            get
            {
                return (this.AreaCalculator());
            }
        }
    }
}









