namespace DesignPatterns.Observer
{
    /// <summary>
    /// 2. 定義 Observer 介面
    /// </summary>
    public interface IObserver
    {
        void Update(string? message);
    }
}
