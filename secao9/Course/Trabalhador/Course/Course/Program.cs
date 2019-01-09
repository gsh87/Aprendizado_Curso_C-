using System;
using Course.Entities.Enums;
using Course.Entities;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string Nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel nivel =Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double salario_base = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Department dept = new Department(deptName);
            Worker worker = new Worker(Nome, nivel, salario_base, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for(int k =1;k<=n;k++)
            {
                Console.WriteLine("Enter #{0} contract data:",k);
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int horas = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(data, valuePerHour, horas);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string MonthYear = Console.ReadLine();
            int month = int.Parse(MonthYear.Substring(0, 2));
            int year = int.Parse(MonthYear.Substring(3, 4));

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Dept:  "+worker.Department.Name);
            Console.WriteLine("Income for: "+worker.Income(year,month).ToString("f2",CultureInfo.InvariantCulture));
            Console.WriteLine("---------------------------------------------------------");

        }
    }
}
