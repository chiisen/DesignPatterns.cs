using DesignPatterns;
using DesignPatterns.Product;

class Program
{
    static void Main(string[] args)
    {
        IProduct productA = SimpleFactory.CreateProduct("A");
        productA.Display();

        IProduct productB = SimpleFactory.CreateProduct("B");
        productB.Display();
    }
}
