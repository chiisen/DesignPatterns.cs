namespace DesignPatterns.Proxy
{
    /// <summary>
    /// 真正的主體
    /// </summary>
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
