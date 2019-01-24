using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Products.Entities;
using System.Globalization;
namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> ListProducts = new List<Product>();
            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            for (int k = 1; k <= N; k++)

            {
                Console.WriteLine($"Product #{k} data");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char resp = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(resp=='c')
                {
                    ListProducts.Add(new Product(name, price));
                }
                else if (resp=='u')
                {
                    Console.Write("Manufacture date (dd/mm/yyyy): ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    ListProducts.Add(new UsedProduct(name, price, data));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    ListProducts.Add(new ImportedProduct(name, price, customs));
                }
               
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Price Tags");

            foreach (Product prod in ListProducts)
            {
                Console.WriteLine(prod.PriceTag());

            }
        }
    }
}
