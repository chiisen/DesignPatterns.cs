namespace DesignPatterns.Memento
{
    /// <summary>
    /// Caretaker class
    /// 負責保存 Memento，但不會修改或檢查 Memento 的內容。
    /// </summary>
    public class Caretaker
    {
        private List<Memento> mementoList = new List<Memento>();

        public void Add(Memento state)
        {
            mementoList.Add(state);
        }

        public Memento Get(int index)
        {
            return mementoList[index];
        }
    }
}
