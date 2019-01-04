using System;

namespace hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos quartos serão alugados:");
            int n = int.Parse(Console.ReadLine());
            Quarto[] vect = new Quarto[9];

            int k = 1;
            while (k <= n)
            {
                Console.WriteLine("Aluguel {0} ",k);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int Nquarto = int.Parse(Console.ReadLine());
                vect[Nquarto] = new Quarto(nome, email, Nquarto);
                k++;
            }

            for(int i = 0;i<9; i++)
            {
                if(vect[i]!=null)
                {
                    Console.WriteLine(vect[i]);
                }

            }
        }
    }
}
