using System;
using System.Collections.Generic;
using System.Text;

namespace Pedidos_Principal.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}
