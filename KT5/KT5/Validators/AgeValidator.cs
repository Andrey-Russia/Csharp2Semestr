using KT5.Models;
using KT5.Exceptons;

public class AgeValidator : IValidatorService
{
    public void Validate(VisitorConfig config)
    {
        if (config.Age <= 0 || config.Age > 200)
        {
            throw new EmptyAgeException();
        }
    }
}