using System;

namespace questao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if ((n % i) == 0)
                {
                    Console.WriteLine("Divisor: {0}", i);
                }
            }
        }
    }
}
