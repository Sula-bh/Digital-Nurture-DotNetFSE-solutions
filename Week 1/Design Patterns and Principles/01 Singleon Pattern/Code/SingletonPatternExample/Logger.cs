namespace SingletonPatternExample;

public class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger()
    {

    }

    public static Logger GetInstance()
    {
        return instance;
    }

    public void Log(String message)
    {
        Console.WriteLine($"LOG: {message}");
    }
}