namespace DesignPatterns.Proxy
{
    // 代理
    public class Proxy : ISubject
    {
        private RealSubject? _realSubject;

        public void Request()
        {
            if (_realSubject == null)
            {
                _realSubject = new RealSubject();
            }
            Console.WriteLine("Proxy: Logging the request.");
            _realSubject.Request();
        }
    }
}
