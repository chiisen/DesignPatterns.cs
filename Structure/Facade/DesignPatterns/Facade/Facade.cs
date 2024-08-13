namespace DesignPatterns.Facade
{
    // Facade 類別
    public class Facade
    {
        private SubsystemA _subsystemA;
        private SubsystemB _subsystemB;
        private SubsystemC _subsystemC;

        public Facade()
        {
            _subsystemA = new SubsystemA();
            _subsystemB = new SubsystemB();
            _subsystemC = new SubsystemC();
        }

        public void Operation1()
        {
            Console.WriteLine("Facade: Operation1");
            _subsystemA.OperationA();
            _subsystemB.OperationB();
        }

        public void Operation2()
        {
            Console.WriteLine("Facade: Operation2");
            _subsystemB.OperationB();
            _subsystemC.OperationC();
        }
    }
}
