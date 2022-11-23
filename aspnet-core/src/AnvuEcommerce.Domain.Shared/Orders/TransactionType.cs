using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
