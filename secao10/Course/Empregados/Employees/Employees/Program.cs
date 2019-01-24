using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees.Entities;
using System.Globalization;
namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>();
            Console.Write("Enter the number of Employee: ");
            int N = int.Parse(Console.ReadLine());
            for (int k = 1; k <= N; k++)
            {
                Console.WriteLine($"Employee #{k} data: ");
                Console.Write("Outsourced (y/n)?: ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



                if (resp == 'y')
                {
                    Console.Write("Additional charge: ");
                    double addicionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Employees.Add(new OutSourcedEmployees(name, hours, valuePerHour, addicionalCharge));
                }
                if(resp =='n')
                {
                    Employees.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("Payments");
            foreach (Employee employ in Employees)
            {
                Console.WriteLine(employ.Name+" - $"+employ.payment().ToString("f2",CultureInfo.InvariantCulture));
            }

        }
    }
}
