using System;

namespace questao5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o valor de N");
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for(int i = n;i>0;i--)
            {
                if(i==n)
                {
                    fatorial = i;
                }
                else
                {
                    fatorial = fatorial * (i);
                }
            }
            Console.WriteLine("Fatorial de {0} é : {1}",n,fatorial);
        }
    }
}
