using System;
using System.Collections.Generic;
using System.Text;

namespace Questao1
{
    class Retangulo
    {
        public double largura;
        public double altura;

        public double Area()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return (2 * altura + 2 * largura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

    }
}
