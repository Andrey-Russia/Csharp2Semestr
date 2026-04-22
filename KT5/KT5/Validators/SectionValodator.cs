using KT5.Models;
using KT5.Exceptons;

namespace KT5.Validators
{
    internal class SectionValodator : IValidatorService
    {
        public void Validate(VisitorConfig config)
        {
            if (string.IsNullOrWhiteSpace(config.Section))
            {
                throw new InvalidSectionException();
            }
        }
    }
}
