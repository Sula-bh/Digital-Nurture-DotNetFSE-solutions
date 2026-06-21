namespace AdapterPatternExample.Gateways;

public class PayPalGateway
{
    public void SendPayment(decimal amount)
    {
        Console.WriteLine($"PayPal processed payment of {amount}");
    }
}