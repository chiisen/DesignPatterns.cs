namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 定義集合的接口
    /// </summary>
    public interface IAbstractCollection
    {
        IIterator CreateIterator();
    }
}
