namespace DesignPatterns.Observer
{
    /// <summary>
    /// 4. 實現具體的 Observer
    /// </summary>
    public class ConcreteObserver : IObserver
    {
        private string _name;

        public ConcreteObserver(string name)
        {
            _name = name;
        }

        public void Update(string? message)
        {
            Console.WriteLine($"Observer {_name} received message: {message}");
        }
    }
}
