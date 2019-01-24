using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax.Entities
{
    class Individual: TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures):base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            double taxa;
            if(AnualIncome<20000.00)
            {
                taxa = 0.15;
            }
            else
            {
                taxa = 0.25;
            }
            return AnualIncome * taxa - HealthExpenditures * 0.50;
        }




    }
}
