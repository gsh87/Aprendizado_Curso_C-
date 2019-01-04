using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = ConstroiConj("A");
            HashSet<int> B = ConstroiConj("B");
            HashSet<int> C = ConstroiConj("C");
            HashSet<int> Uniao = new HashSet<int>();
            Uniao.UnionWith(A);
            Uniao.UnionWith(B);
            Uniao.UnionWith(C);

            int n = Uniao.Count;
            Console.WriteLine("Total de alunos: "+n);

        }

        static HashSet<int> ConstroiConj(string conjunto)
        {
            Console.WriteLine("O curso {0} possui quantos alunos? ",conjunto);
            int QtsA = int.Parse(Console.ReadLine());
            HashSet<int> A = new HashSet<int>();
            int controle = 0;
            while (controle < QtsA)
            {
                A.Add(int.Parse(Console.ReadLine()));
                controle++;
            }
            return A;
        }

    }
}