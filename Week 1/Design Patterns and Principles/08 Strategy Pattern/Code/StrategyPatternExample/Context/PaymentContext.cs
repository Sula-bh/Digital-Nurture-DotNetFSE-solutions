using StrategyPatternExample.Strategies;

namespace StrategyPatternExample.Context;

public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void ExecutePayment(decimal amount)
    {
        paymentStrategy.Pay(amount);
    }
}