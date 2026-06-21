using DecoratorPatternExample.Notifiers;
using DecoratorPatternExample.Decorators;

INotifier notifier =
    new SlackNotifierDecorator(
        new SMSNotifierDecorator(
            new EmailNotifier()));

notifier.Send("Server is down");
