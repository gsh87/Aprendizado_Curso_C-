using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Exercicio.Entities;
using Exercicio.Entities.Enuns;

namespace Exercicio.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        // construtores
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        // metodos
        public  void AddOrder(OrderItem item)
        {
            Items.Add(item);
        }

        public void ReniveOrder(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status: "+Status);
            sb.AppendLine("Client: "+Client);
            sb.AppendLine("Order Items: ");
            foreach(OrderItem it in Items)
            {
                sb.AppendLine(it.ToString());
            }
            sb.AppendLine("Total Price: $" + Total().ToString("f2", CultureInfo.InvariantCulture));
            return sb.ToString();


        }
    }
}
