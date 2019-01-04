using System.Globalization;
namespace Questao3
{
    class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;
        public double Gap_Notas;

        public string Resultado()
        {
            if (((NotaA + NotaB + NotaC)) >= 60.00)
            {
                Gap_Notas = 60.00 - (NotaA + NotaB + NotaC);
                return "Aprovado";
            }
            else
            {
                Gap_Notas = 60.00 - (NotaA + NotaB + NotaC);
                return "Reprovado";

            }

        }


    }
}
