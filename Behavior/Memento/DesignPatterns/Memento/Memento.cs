namespace DesignPatterns.Memento
{
    /// <summary>
    /// Memento class
    /// 保存 Originator 的狀態。
    /// </summary>
    public class Memento
    {
        public string State { get; private set; }

        public Memento(string state)
        {
            State = state;
        }
    }
}
