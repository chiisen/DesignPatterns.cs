namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 定義迭代器的接口
    /// </summary>
    public interface IIterator
    {
        object? First();
        object? Next();
        bool IsDone { get; }
        object? CurrentItem { get; }
    }
}
