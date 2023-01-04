using System;
using System.Collections.Generic;
using System.Text;

namespace AnvuEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder = 1,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
