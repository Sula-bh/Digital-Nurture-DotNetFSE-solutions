using AdapterPatternExample.Adapters;
using AdapterPatternExample.Gateways;
using AdapterPatternExample.PaymentProcessors;

IPaymentProcessor paypal =
    new PayPalAdapter(new PayPalGateway());

IPaymentProcessor stripe =
    new StripeAdapter(new StripeGateway());

IPaymentProcessor razorpay =
    new RazorpayAdapter(new RazorpayGateway());

paypal.ProcessPayment(1000);
stripe.ProcessPayment(2000);
razorpay.ProcessPayment(3000);
