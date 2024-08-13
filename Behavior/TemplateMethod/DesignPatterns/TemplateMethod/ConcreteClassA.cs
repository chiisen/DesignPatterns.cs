namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// 具體類別，實現基本操作
    /// </summary>
    class ConcreteClassA : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassA: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassA: PrimitiveOperation2");
        }

        protected override void ConcreteOperation()
        {
            Console.WriteLine("ConcreteClassA: ConcreteOperation");
        }
    }
}
