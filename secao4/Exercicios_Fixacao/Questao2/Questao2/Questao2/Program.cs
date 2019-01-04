using System;
using System.Globalization;
namespace Questao2
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario fun = new Funcionario();
            Console.Write("Nome: ");
            fun.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Salario Bruto: ");
            fun.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Imposto: ");
            fun.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine();
            fun.SalarioLiquido();
            Console.WriteLine("Funcionario: "+fun);

            Console.WriteLine();
            Console.WriteLine("Digite a porcentagem para o aumento: ");
            double aumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            fun.AumentoSalario(aumento);

            Console.WriteLine("Dados atualizados: "+fun);



        }
    }
}
