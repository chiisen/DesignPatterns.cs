namespace DesignPatterns.Visitor
{
    /// <summary>
    /// 2. 定義訪問者介面和具體訪問者類別
    /// </summary>
    public interface IVisitor
    {
        void VisitConcreteElementA(ConcreteElementA elementA);
        void VisitConcreteElementB(ConcreteElementB elementB);
    }
}
