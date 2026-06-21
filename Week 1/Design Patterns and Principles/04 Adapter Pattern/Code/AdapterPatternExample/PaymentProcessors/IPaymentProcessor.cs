namespace AdapterPatternExample.PaymentProcessors;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}