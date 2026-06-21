namespace AdapterPatternExample.Gateways;

public class StripeGateway
{
    public void MakeCharge(decimal amount)
    {
        Console.WriteLine($"Stripe charged {amount}");
    }
}