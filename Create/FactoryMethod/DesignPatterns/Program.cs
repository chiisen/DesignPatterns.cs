using DesignPatterns.Product;

/// <summary>
/// 客戶端代碼
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Creator creatorA = new ConcreteCreatorA();
        creatorA.SomeOperation();

        Creator creatorB = new ConcreteCreatorB();
        creatorB.SomeOperation();
    }
}
