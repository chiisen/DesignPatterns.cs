namespace DesignPatterns.Mediator
{
    /// <summary>
    /// Mediator 介面
    /// </summary>
    public interface IMediator
    {
        void Notify(object sender, string eventCode);
    }
}
