namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 具體的組件類別 1
    /// </summary>
    public class Component1 : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("Component 1 does A.");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("Component 1 does B.");
        }
    }
    /// <summary>
    /// 具體的組件類別 2
    /// </summary>
    public class Component2 : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("Component 2 does C.");
        }

        public void DoD()
        {
            Console.WriteLine("Component 2 does D.");
            _mediator.Notify(this, "D");
        }
    }
}
