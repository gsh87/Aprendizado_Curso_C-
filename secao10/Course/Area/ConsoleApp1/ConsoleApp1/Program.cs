using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System.Globalization;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> Shapes = new List<Shape>();
            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangule of circle (r/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());


                if(type=='r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Retangule(width, height, color));
                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Shapes.Add(new Circle(radius, color));
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("Shape areas: ");
                foreach (Shape item in Shapes)
                {
                    Console.WriteLine(" shape: " + item.Area().ToString("f2", CultureInfo.InvariantCulture));
                }



            }

        }
    }
}
