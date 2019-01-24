using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio.Entities
{
    class OrderItem
    {
        public Product Produto { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        // construtores
        public OrderItem()
        {

        }

        public OrderItem(Product produto, double price, double quantity)
        {
            Produto = produto;
            Price = price;
            Quantity = quantity;
        }



        // metodos
        public  double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Produto.Name +
                ", $" +
                Price.ToString("f2", CultureInfo.InvariantCulture)+
                ", Quantity: "+
                Quantity+
                ", SubTotal: "+SubTotal();
        }
    }
}
