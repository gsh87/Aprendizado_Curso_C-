using System.Globalization;
namespace Banco
{
    class Cliente
    {
        public int _conta { get;  private set; }
        public string Nome { get; set; }
        public double _saldo { get;  private set; }

        // construtores e sobrecarga
        public Cliente(int conta, string nome, double saldo)
        {
            _conta = conta;
            Nome = nome;
            _saldo = saldo;
        }


        //prorpeties
        public void FazDeposito(double deposito)
        {
            _saldo += deposito;
        }

        public void FazSaque(double saque)
        {
            _saldo = _saldo - saque - 5.00;
        }
        public override string ToString()
        {
            return "Conta: "+_conta+
                " ,Nome: "+Nome +
                " ,saldo: " +
                _saldo.ToString("f2", CultureInfo.InvariantCulture);
        }



    }
}
