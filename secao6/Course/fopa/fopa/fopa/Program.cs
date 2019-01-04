using System;
using System.Globalization;
using System.Collections.Generic;

namespace fopa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("numero de funcionarios a serem registrados: ");
            int N = int.Parse(Console.ReadLine());

            List<Funcionario> Fun = new List<Funcionario>();

            int k = 1;
            while(k<=N)
            {

                Console.WriteLine("Empregado {0}:",k);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());
                Fun.Add(new Funcionario(nome, id, salario));
                Console.WriteLine("------------------------------");
                k++;
            }


            // modificar o salario
            Console.WriteLine("Entre com o ID do funcionario");
            int IdPesquisa = int.Parse(Console.ReadLine());

            Funcionario empreg = Fun.Find(x => x.Id == IdPesquisa);

            if(empreg!=null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                empreg.ModSalario(porcentagem);
            }
            else
            {
                Console.WriteLine("Funcionario nao encontrado.");
            }
            Console.WriteLine("------------------------------");
            foreach (Funcionario empregado in Fun)
            {
                Console.WriteLine(empregado);
            }
            Console.WriteLine("------------------------------");
        }
    }
}
