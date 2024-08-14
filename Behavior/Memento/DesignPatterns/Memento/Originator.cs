namespace DesignPatterns.Memento
{
    /// <summary>
    /// Originator class
    /// 創建 Memento 並從 Memento 中恢復狀態。
    /// </summary>
    public class Originator
    {
        public string State { get; set; }

        public Memento SaveStateToMemento()
        {
            return new Memento(State);
        }

        public void GetStateFromMemento(Memento memento)
        {
            State = memento.State;
        }
    }
}
