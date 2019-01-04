using System;

namespace ConsoleApp1Questao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um numero: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 1; i <= x; i++)
            {

                if ((i - 1) % 2 == 0)
                {
                    Console.WriteLine(" iMPAR: {0}", i);
                }

            }
        }
    }
}
