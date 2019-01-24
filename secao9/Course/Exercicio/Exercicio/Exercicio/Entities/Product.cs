using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double price { get; set; }
        // construtores
        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            this.price = price;
        }
    }
}
