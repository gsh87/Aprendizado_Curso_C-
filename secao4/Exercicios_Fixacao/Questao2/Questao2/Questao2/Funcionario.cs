using System.Globalization;
namespace Questao2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto, Imposto,Salario_Liquido;

        public void  SalarioLiquido()
        {
            Salario_Liquido= SalarioBruto - Imposto;
        }
        
        public void AumentoSalario(double taxa)
        {
            Salario_Liquido = Salario_Liquido + taxa * SalarioBruto;
        }

        public override string ToString()
        {
            return Nome +
                   ", $ " +
                   Salario_Liquido.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
