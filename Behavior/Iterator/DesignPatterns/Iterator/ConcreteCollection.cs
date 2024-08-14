using System.Collections;

namespace DesignPatterns.Iterator
{
    /// <summary>
    /// 具體集合類別
    /// </summary>
    public class ConcreteCollection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }

        // 獲取集合中的項目數量
        public int Count
        {
            get { return _items.Count; }
        }

        // 索引器
        public object? this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }
    }
}
