namespace ObserverPatternExample.Observers;

public class MobileApp : IObserver
{
    public void Update(string stockName, decimal price)
    {
        Console.WriteLine(
            $"Mobile App: {stockName} is now {price}");
    }
}