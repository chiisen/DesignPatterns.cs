namespace DesignPatterns.Adapter
{
    /// <summary>
    /// 被適配的類別
    /// </summary>
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee 的 SpecificRequest 被呼叫");
        }
    }
}
