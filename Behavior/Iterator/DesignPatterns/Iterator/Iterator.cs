namespace DesignPatterns.Iterator
{
    // 具體迭代器類別
    public class Iterator : IIterator
    {
        private ConcreteCollection? _collection;
        private int _current = 0;

        public Iterator(ConcreteCollection collection)
        {
            this._collection = collection;
        }

        public object? First()
        {
            _current = 0;
            if (_collection != null)
            {
                return _collection[_current];
            }
            else
            {
                return null;
            }
        }

        public object? Next()
        {
            _current++;
            if (!IsDone)
            {
                if (_collection != null)
                {
                    return _collection[_current];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public bool IsDone
        {
            get 
            {
                if (_collection != null)
                {
                    return _current >= _collection.Count;
                }
                else
                {
                    return false;
                }                
            }
        }

        public object? CurrentItem
        {
            get 
            {
                if (_collection != null)
                {
                    return _collection[_current];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
