using ConsoleApp1.Entities.Enums;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Entities
{
    class Retangule: Shape
    {
        public double width { get; set; }
        public double height { get; set; }


        public Retangule(Color color):base(color)
        {

        }

        public Retangule(double width, double height, Color color): base(color)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }
    }
}
