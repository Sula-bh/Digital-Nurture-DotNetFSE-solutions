using SingletonPatternExample;

Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Log("First message");
logger2.Log("Second message");

Console.WriteLine($"logger1 == logger2: {logger1 == logger2}");

Console.WriteLine(logger1.GetHashCode());
Console.WriteLine(logger2.GetHashCode());
