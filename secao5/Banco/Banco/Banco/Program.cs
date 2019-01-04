using System;
using System.Globalization;
namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            int Conta;
            string Titular;
            char FlagDeposito;
            double Saldo;
            double Saque,Deposito;
            Console.WriteLine("Entre com o número de conta:");
            Conta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o titular da conta:");
            Titular = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial (s/n)?");
            FlagDeposito = char.Parse(Console.ReadLine());

            if(FlagDeposito == 's')
            {
                Console.WriteLine("Digite o deposito:");
               Saldo = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            }
            else
            {
                Saldo = 0.00;
            }
            Cliente clt = new Cliente(Conta, Titular, Saldo);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(clt);


            //deposito
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.Write("Entre com um valor para deposito: ");
            Deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            clt.FazDeposito(Deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(clt);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");


            // saque
            Console.WriteLine("------------------------------------");
            Console.Write("Entre com um valor para saque: ");
            Saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            clt.FazSaque(Saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(clt);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
        }
       
    }
}
