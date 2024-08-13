using DesignPatterns.Facade;

/// <summary>
/// 客戶端程式碼
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Facade facade = new Facade();

        facade.Operation1();
        facade.Operation2();
    }
}
