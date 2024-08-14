namespace DesignPatterns.Visitor
{
    public class ConcreteVisitor1 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine($"{elementA.OperationA()} visited by ConcreteVisitor1");
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine($"{elementB.OperationB()} visited by ConcreteVisitor1");
        }
    }

    public class ConcreteVisitor2 : IVisitor
    {
        public void VisitConcreteElementA(ConcreteElementA elementA)
        {
            Console.WriteLine($"{elementA.OperationA()} visited by ConcreteVisitor2");
        }

        public void VisitConcreteElementB(ConcreteElementB elementB)
        {
            Console.WriteLine($"{elementB.OperationB()} visited by ConcreteVisitor2");
        }
    }
}
