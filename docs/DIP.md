我們可以創建一個日誌記錄器的接口（ILogger），並提供兩種實現：一種是將日誌記錄到文件（FileLogger），另一種是將日誌記錄到控制台（ConsoleLogger）。這樣，應用程序可以依賴於ILogger接口，而不是具體的實現類，從而達到依賴反轉。
```c#
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        // 將日誌記錄到文件的實現
        Console.WriteLine($"File log: {message}");
    }
}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        // 將日誌記錄到控制台的實現
        Console.WriteLine($"Console log: {message}");
    }
}

public class Application
{
    private readonly ILogger _logger;

    public Application(ILogger logger)
    {
        _logger = logger;
    }

    public void DoSomething()
    {
        _logger.Log("操作信息");
    }
}

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new FileLogger(); // 或者 new ConsoleLogger();
        Application app = new Application(logger);
        app.DoSomething();
    }
}
```