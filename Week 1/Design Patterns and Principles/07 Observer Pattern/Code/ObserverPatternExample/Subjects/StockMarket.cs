using ObserverPatternExample.Observers;

namespace ObserverPatternExample.Subjects;

public class StockMarket : IStock
{
    private readonly List<IObserver> observers = new();

    private string stockName;
    private decimal stockPrice;

    public StockMarket(string stockName)
    {
        this.stockName = stockName;
    }

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void DeregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(stockName, stockPrice);
        }
    }

    public void SetPrice(decimal price)
    {
        stockPrice = price;

        Console.WriteLine(
            $"{stockName} price changed to {stockPrice}");

        NotifyObservers();
    }
}