namespace DesignPatterns.Visitor
{
    /// <summary>
    /// 1. 定義元素介面和具體元素類別
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
