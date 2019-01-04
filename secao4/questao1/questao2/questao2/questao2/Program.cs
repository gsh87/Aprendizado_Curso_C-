using System;
using System.Globalization;
namespace questao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Entre com o nome da pessoa:");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade:");
            x.Salario = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com o nome da pessoa:");
            y.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade:");
            y.Salario = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


            double media = (x.Salario + y.Salario) / 2;
            Console.WriteLine("Salario medio"+media.ToString("f2",CultureInfo.InvariantCulture));

        }
    }
}
