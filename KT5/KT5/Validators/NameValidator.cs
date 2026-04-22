using KT5.Models;
using KT5.Exceptons;

public class NameValidator : IValidatorService
{
    public void Validate(VisitorConfig config)
    {
        if (string.IsNullOrWhiteSpace(config.Name))
            throw new EmptyNameException();
    }
}