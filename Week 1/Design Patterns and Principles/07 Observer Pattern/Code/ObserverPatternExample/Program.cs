using ObserverPatternExample.Subjects;
using ObserverPatternExample.Observers;

StockMarket stockMarket = new StockMarket("AAPL");

IObserver mobile = new MobileApp();
IObserver web = new WebApp();

stockMarket.RegisterObserver(mobile);
stockMarket.RegisterObserver(web);

stockMarket.SetPrice(150);

Console.WriteLine();

stockMarket.SetPrice(175);

stockMarket.DeregisterObserver(web);

Console.WriteLine();

stockMarket.SetPrice(200);