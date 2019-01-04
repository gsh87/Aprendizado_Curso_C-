using System;
using System.Globalization;
namespace Questao1
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo Ret = new Retangulo();
            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            Ret.altura = double.Parse(Console.ReadLine());
            Ret.largura = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Area:" + Ret.Area().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Perimetro:" + Ret.Perimetro().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.Write("Diagonal:" + Ret.Diagonal().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();

        }

    }
}
