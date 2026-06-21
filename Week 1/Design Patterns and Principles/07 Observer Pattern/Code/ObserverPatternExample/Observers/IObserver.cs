namespace ObserverPatternExample.Observers;

public interface IObserver
{
    void Update(string stockName, decimal price);
}