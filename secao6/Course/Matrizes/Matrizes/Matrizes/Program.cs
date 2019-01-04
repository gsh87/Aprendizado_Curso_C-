using System;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de linhas: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com a quantidade de colunas: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];


            // carregamento da base
            for (int i = 0; i < n; i++)
            {
                string[] vector = Console.ReadLine().Split(' ');
                for (int k = 0; k < m; k++)
                {
                    matriz[i, k] = int.Parse(vector[k]);
                }
            }

            Console.Write("Numero a ser procurado: ");
            int x = int.Parse(Console.ReadLine());

            /// mapeamento
            for (int i = 0; i < n; i++)
            {
                for (int J = 0; J < m; J++)
                {
                    if (matriz[i, J] == x)
                    {
                        Console.WriteLine("---------------------------------------------");
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("SUPERIOR: " + matriz[i - 1, J]);
                        }
                        else
                        {
                            Console.WriteLine("SUPERIOR: ");
                        }
                        if (i + 1 < n)
                        {
                            Console.WriteLine("INFERIOR: " + matriz[i + 1, J]);
                        }
                        else
                        {
                            Console.WriteLine("INFERIOR:  ");
                        }
                        if(J-1>=0)
                        {
                            Console.WriteLine("ESQUERDO: " + matriz[i, J-1]);
                        }
                        else
                        {
                            Console.WriteLine("ESQUERDO: ");
                        }
                        if(J+1<n)
                        {
                            Console.WriteLine("DIREITO: " + matriz[i, J + 1]);
                        }
                        else
                        {
                            Console.WriteLine("DIREITO: ");
                        }
                        Console.WriteLine("---------------------------------------------");

                    }

                }
            }











        }

    }
}
