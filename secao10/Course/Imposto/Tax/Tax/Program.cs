using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax.Entities;
using System.Globalization;
namespace Tax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> Lista = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or Company (i/c)? ");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual Income: ");
                double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(resp=='i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Lista.Add(new Individual(name, anualIncome, healthExpenditure));
                }
                else
                {
                    Console.Write("Number of employee: ");
                    int employee = int.Parse(Console.ReadLine());
                    Lista.Add(new Company(name, anualIncome, employee));
                }


            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Taxes paid: ");
            foreach (TaxPayer item in Lista)
            {
                Console.WriteLine(item.Name+" : $ "+item.tax().ToString("f2",CultureInfo.InvariantCulture));
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Total taxes: ");

            double sum = 0;
            foreach (TaxPayer item in Lista)
            {
                sum += item.tax();
            }
            Console.WriteLine("Total: "+sum.ToString("f2",CultureInfo.InvariantCulture));
        }
    }
}
