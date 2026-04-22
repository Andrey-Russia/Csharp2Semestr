using KT5.Models;
using KT5.Exceptons;

namespace KT5.Validators
{
    internal class PriceValidator : IValidatorService
    {
        public void Validate(VisitorConfig config)
        {
            if (config.Price <= 0)
            {
                throw new InvalidPriceException();
            }
        }
    }
}
