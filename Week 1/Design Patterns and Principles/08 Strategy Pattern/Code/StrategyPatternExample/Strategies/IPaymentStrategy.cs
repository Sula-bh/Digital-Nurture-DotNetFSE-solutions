namespace StrategyPatternExample.Strategies;

public interface IPaymentStrategy
{
    void Pay(decimal amount);
}