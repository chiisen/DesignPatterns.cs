using DesignPatterns.Adapter;

/// <summary>
/// 客戶端程式碼
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        // 使用 ITarget 介面呼叫 Request 方法
        target.Request();
    }
}