using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Entities
{
    class Company:TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            double taxa;
            if(NumberOfEmployees <= 10)
            {
                taxa = 0.16;
            }
            else
            {
                taxa = 0.14;
            }
            return AnualIncome * taxa;
        }

        // constructs

    }
}
