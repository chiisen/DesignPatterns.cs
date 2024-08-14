namespace DesignPatterns.Mediator
{
    /// <summary>
    /// 具體的 Mediator 類別
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        private Component1 _component1;
        private Component2 _component2;

        public ConcreteMediator(Component1 component1, Component2 component2)
        {
            _component1 = component1;
            _component1.SetMediator(this);
            _component2 = component2;
            _component2.SetMediator(this);
        }

        public void Notify(object sender, string eventCode)
        {
            if (eventCode == "A")
            {
                Console.WriteLine("Mediator reacts on A and triggers following operations:");
                _component2.DoC();
            }
            else if (eventCode == "D")
            {
                Console.WriteLine("Mediator reacts on D and triggers following operations:");
                _component1.DoB();
                _component2.DoC();
            }
        }
    }
}
