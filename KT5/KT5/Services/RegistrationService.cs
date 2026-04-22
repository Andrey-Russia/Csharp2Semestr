using KT5.Models;
using KT5.Payment;
using KT5.Validators;
using System;
using System.Collections.Generic;

namespace RegistrationApp.Services
{
    public class RegistrationService
    {
        private IPaymentStrategy _paymentStrategy;
        private readonly List<IValidatorService> _validators;

        public RegistrationService(List<IValidatorService> validators)
        {
            _validators = validators;
        }

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Register(VisitorConfig config)
        {
            try
            {
                foreach (var validator in _validators)
                {
                    validator.Validate(config);
                }

                Console.WriteLine("Валидация прошла успешно");

                _paymentStrategy?.Pay(config.Price);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Регистрация завершена");
            }
        }
    }
}