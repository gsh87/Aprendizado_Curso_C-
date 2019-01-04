using System;
using System.Globalization;
namespace triangulo
{
    class Program2
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();


            Console.WriteLine("medidas de X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("medidas de Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            double AreaX =x.Area();

            double AreaY = y.Area();
            Console.WriteLine("Area de X: " + AreaX.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y: " + AreaY.ToString("f2", CultureInfo.InvariantCulture));

            if (AreaX > AreaY)
            {
                Console.WriteLine(" Maior: Area X");
            }
            else if (AreaY > AreaX)
            {
                Console.WriteLine(" Maior: Area Y");
            }
            else
            {
                Console.WriteLine("Iguais");
            }


        }
    }
}
