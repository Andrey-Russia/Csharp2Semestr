using KT5.Payment;

public class CoinPayment : IPaymentStrategy
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Оплата монетами: {amount}");
    }
}