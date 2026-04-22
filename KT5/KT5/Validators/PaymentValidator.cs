using KT5.Exceptons;
using KT5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5.Validators
{
    internal class PaymentValidator : IValidatorService
    {
        public void Validate(VisitorConfig config)
        {
            if (config.Payment < config.Price)
            {
                throw new InsufficientPaymentException();
            }
        }
    }
}
