using Circle_Objects_Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects_Lab
{
    public class Circle
    {
        //properties
        private double radius;

        public double Radius
        {
            get { return radius; }
        }

        //C = πd 
        //Constructor
        public Circle(double radius)
        {
            this.radius = radius; //the single entered input
        }

        //Method
        public double CalculateCircumference() //returns the basic Circumference
        {
            return 2 * Math.PI * radius;
        }
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);//basic math for 
        }
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }
        private string FormatNumber(double x)
        {
            return x.ToString("0.00");
        }
    }
}


