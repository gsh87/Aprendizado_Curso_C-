using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Products.Entities
{
    class UsedProduct:Product
    {
        public DateTime Date { get; set; }

        // construct
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date):base(name,price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Name+
                " (used) $ "+
                Price.ToString("f2", CultureInfo.InvariantCulture) +
                " (Manufacture date:  "+Date.ToString("dd/MM/yyyy")+
                ")";
        }
    }
}
