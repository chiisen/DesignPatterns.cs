namespace DesignPatterns.Observer
{
    /// <summary>
    /// 3. 實現具體的 Subject
    /// </summary>
    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string? _state;

        public string? State
        {
            get { return _state; }
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(_state);
            }
        }
    }
}
