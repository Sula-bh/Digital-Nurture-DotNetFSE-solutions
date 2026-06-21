namespace ObserverPatternExample.Observers;

public class WebApp : IObserver
{
    public void Update(string stockName, decimal price)
    {
        Console.WriteLine(
            $"Web App: {stockName} is now {price}");
    }
}