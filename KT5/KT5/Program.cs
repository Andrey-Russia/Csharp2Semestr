using KT5.Models;
using KT5.Payment;
using KT5.Validators;
using RegistrationApp.Services;


class Program
{
    static void Main()
    {
        var validators = new List<IValidatorService>
        {
            new NameValidator(),
            new AgeValidator(),
            new SectionValodator(),
            new PriceValidator(),
            new PaymentValidator()
        };

        var service = new RegistrationService(validators);

        Console.WriteLine("=== Регистрация на кружок ===");

        while (true)
        {
            try
            {
                Console.Write("Имя: ");
                string name = Console.ReadLine();

                Console.Write("Возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Секция: ");
                string section = Console.ReadLine();

                Console.Write("Цена: ");
                decimal price = decimal.Parse(Console.ReadLine());

                Console.Write("Сколько платите: ");
                decimal payment = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Выберите способ оплаты: 1 - Наличные, 2 - Карта, 3 - Монеты");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        service.SetPaymentStrategy(new CashPayment());
                        break;
                    case "2":
                        service.SetPaymentStrategy(new CardPayment());
                        break;
                    case "3":
                        service.SetPaymentStrategy(new CoinPayment());
                        break;
                    default:
                        Console.WriteLine("Неверный выбор, по умолчанию карта");
                        service.SetPaymentStrategy(new CardPayment());
                        break;
                }

                var visitor = new VisitorConfig(name, age, section, price, payment);

                service.Register(visitor);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка ввода! Введите число корректно.");
            }

            Console.WriteLine("\nПовторить? (y/n)");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }
    }
}