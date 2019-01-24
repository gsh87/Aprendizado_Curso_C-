using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entities.Enums;
namespace ConsoleApp1.Entities
{
    abstract class Shape
    {
        public Color color { get; set; }

        public Shape(Color color)
        {
            this.color = color;
        }

        ///
        public abstract double Area();
    }
}
