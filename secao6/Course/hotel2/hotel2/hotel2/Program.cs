using System;

namespace hotel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de quartos: ");
            int N = int.Parse(Console.ReadLine());
            Quarto[] vet = new Quarto[10];
            int k = 1;
            while (k <= N)
            {
                Console.WriteLine("Aluguel {0}: ", k);
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto: ");
                int nQuarto = int.Parse(Console.ReadLine());
                vet[nQuarto] = new Quarto(nome, email, nQuarto);
                k++;
            }

            for (int i = 0; i <= 9; i++)
            {
                if (vet[i] != null)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
