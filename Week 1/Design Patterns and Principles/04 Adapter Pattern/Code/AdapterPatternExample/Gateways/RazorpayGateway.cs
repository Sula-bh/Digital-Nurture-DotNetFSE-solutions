namespace AdapterPatternExample.Gateways;

public class RazorpayGateway
{
    public void Pay(decimal amount)
    {
        Console.WriteLine($"Razorpay paid {amount}");
    }
}