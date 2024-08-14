namespace DesignPatterns.Command
{
    /// <summary>
    /// 1. 定義命令介面
    /// 我們需要定義一個命令介面，所有具體命令都將實現這個介面。
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }
}
