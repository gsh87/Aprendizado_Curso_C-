using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Products.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        // construct
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        // functions
        public virtual string PriceTag()
        {
            return Name +
                " $ " +
                Price.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
