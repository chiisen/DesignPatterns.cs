
using DesignPatterns.Proxy;

/// <summary>
/// 客戶端程式碼
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        ISubject proxy = new Proxy();
        proxy.Request();
    }
}
