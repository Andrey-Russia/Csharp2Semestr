using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5.Exceptons
{
    internal class InsufficientPaymentException : Exception
    {
        public InsufficientPaymentException() : base ("Недостаточно средств нишеброд ебанный.") { }
    }
}
