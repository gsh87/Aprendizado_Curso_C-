using System;
using System.Globalization;
namespace questao7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com N:");
            int n = int.Parse(Console.ReadLine());
            for(int i =1;i<=n;i++)
            {
                double quadrado, cubo;
                quadrado = Math.Pow(i, 2);
                cubo = Math.Pow(i, 3);
                Console.WriteLine("{0} {1} {2}",i,quadrado.ToString("f0",CultureInfo.InvariantCulture),cubo.ToString("f0",CultureInfo.InvariantCulture));
            }
        }
    }
}
