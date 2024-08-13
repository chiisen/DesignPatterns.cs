namespace DesignPatterns.Adapter
{
    // 適配器
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public void Request()
        {
            // 呼叫 Adaptee 的 SpecificRequest 方法
            _adaptee.SpecificRequest();
        }
    }
}
