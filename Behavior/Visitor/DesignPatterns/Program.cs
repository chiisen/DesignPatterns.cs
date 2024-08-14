using DesignPatterns.Visitor;

class Program
{
    static void Main(string[] args)
    {
        List<IElement> elements = new List<IElement>
        {
            new ConcreteElementA(),
            new ConcreteElementB()
        };

        IVisitor visitor1 = new ConcreteVisitor1();
        IVisitor visitor2 = new ConcreteVisitor2();

        foreach (var element in elements)
        {
            element.Accept(visitor1);
            element.Accept(visitor2);
        }
    }
}
