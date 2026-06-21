using AdapterPatternExample.Gateways;
using AdapterPatternExample.PaymentProcessors;

namespace AdapterPatternExample.Adapters;

public class PayPalAdapter : IPaymentProcessor
{
    private readonly PayPalGateway gateway;

    public PayPalAdapter(PayPalGateway gateway)
    {
        this.gateway = gateway;
    }

    public void ProcessPayment(decimal amount)
    {
        gateway.SendPayment(amount);
    }
}