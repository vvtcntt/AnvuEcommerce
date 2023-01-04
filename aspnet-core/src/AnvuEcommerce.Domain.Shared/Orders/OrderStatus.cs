using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Orders
{
    public enum OrderStatus
    {
        New = 1,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
