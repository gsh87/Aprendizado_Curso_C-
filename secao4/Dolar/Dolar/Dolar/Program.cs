using System;
using System.Globalization;
namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a contação do dolar ?");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dolares voce vai comprar ?");
            double volume = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double necessario = Calculadora.Valores(dolar, volume);
            Console.WriteLine("Valor a ser pago em reais = "+necessario.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
