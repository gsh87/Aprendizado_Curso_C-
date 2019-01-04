using System;
using System.Globalization;

namespace Questao3
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota 1: ");
            aluno.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Nota 2: ");
            aluno.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Nota 3: ");
            aluno.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine(aluno.Resultado());
            if (aluno.Gap_Notas >0)
            {
                Console.WriteLine("Nota Faltante: "+aluno.Gap_Notas.ToString("f2",CultureInfo.InvariantCulture));
            }


        }
    }
}
