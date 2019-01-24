using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
namespace ConsoleApp1.Entities
{
    class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle(double radius,Color color):base(color)
        {
            Radius = radius; 
        }

        public override double Area()
        {
            return Math.Pow(Radius,2)*Math.PI;
        }
    }
}
