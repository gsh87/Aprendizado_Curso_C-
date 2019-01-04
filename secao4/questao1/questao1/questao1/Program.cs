using System;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Registro x, y;
            x = new Registro();
            y = new Registro();

            Console.WriteLine("Entre com o nome da pessoa:");
            x.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade:");
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome da pessoa:");
            y.Nome = Console.ReadLine();

            Console.WriteLine("Entre com a idade:");
            y.Idade = int.Parse(Console.ReadLine());


            if(x.Idade>y.Idade)
            {
                Console.WriteLine("Mais Velho: {0}",x.Nome);
            }
            else if(x.Idade<y.Idade)
            {
                Console.WriteLine("Mais Velho: {0}", y.Nome);
            }
            else
            {
                Console.WriteLine("Iguais");
            }

        }
    }
}
