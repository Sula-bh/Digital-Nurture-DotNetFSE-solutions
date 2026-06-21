using AdapterPatternExample.Gateways;
using AdapterPatternExample.PaymentProcessors;

namespace AdapterPatternExample.Adapters;

public class RazorpayAdapter : IPaymentProcessor
{
    private readonly RazorpayGateway gateway;

    public RazorpayAdapter(RazorpayGateway gateway)
    {
        this.gateway = gateway;
    }

    public void ProcessPayment(decimal amount)
    {
        gateway.Pay(amount);
    }
}