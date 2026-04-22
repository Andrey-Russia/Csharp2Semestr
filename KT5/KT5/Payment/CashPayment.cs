using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5.Payment
{
    internal class CashPayment : IPaymentStrategy
    {
        public void Pay(Decimal amount)
        {
            Console.WriteLine($"Оплата наличными: {amount}");
        }

    }
}
