using StrategyPatternExample.Context;
using StrategyPatternExample.Strategies;

PaymentContext context =new PaymentContext(new CreditCardPayment());

context.ExecutePayment(1000);

Console.WriteLine();

context.SetStrategy(new PayPalPayment());

context.ExecutePayment(2000);
