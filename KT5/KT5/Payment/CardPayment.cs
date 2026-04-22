using KT5.Payment;

public class CardPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата картой: {amount}");
    }
}