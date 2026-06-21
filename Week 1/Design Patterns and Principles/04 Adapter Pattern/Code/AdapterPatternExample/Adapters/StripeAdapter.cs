using AdapterPatternExample.Gateways;
using AdapterPatternExample.PaymentProcessors;

namespace AdapterPatternExample.Adapters;

public class StripeAdapter : IPaymentProcessor
{
    private readonly StripeGateway gateway;

    public StripeAdapter(StripeGateway gateway)
    {
        this.gateway = gateway;
    }

    public void ProcessPayment(decimal amount)
    {
        gateway.MakeCharge(amount);
    }
}