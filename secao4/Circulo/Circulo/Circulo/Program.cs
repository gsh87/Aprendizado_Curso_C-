using System;
using System.Globalization;
namespace Circulo
{
    class Program
    {

        static void Main(string[] args)
        {
            
            double raio;
            Console.WriteLine("Entre com o raio");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comprimento = Calculadora.Circunferencia(raio);
            double area = Calculadora.Area(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Compromimento: " + comprimento.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + area.ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("f2", CultureInfo.InvariantCulture));

        }




    }


}
