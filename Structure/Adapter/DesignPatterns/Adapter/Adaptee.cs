namespace DesignPatterns.Adapter
{
    // 被適配的類別
    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Adaptee 的 SpecificRequest 被呼叫");
        }
    }
}
