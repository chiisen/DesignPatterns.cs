namespace DesignPatterns.Visitor
{
    public class ConcreteElementA : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementA(this);
        }

        public string OperationA()
        {
            return "ConcreteElementA";
        }
    }

    public class ConcreteElementB : IElement
    {
        public void Accept(IVisitor visitor)
        {
            visitor.VisitConcreteElementB(this);
        }

        public string OperationB()
        {
            return "ConcreteElementB";
        }
    }
}
