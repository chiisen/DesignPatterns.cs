namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// 另一個具體類別，實現基本操作
    /// </summary>
    class ConcreteClassB : AbstractClass
    {
        protected override void PrimitiveOperation1()
        {
            Console.WriteLine("ConcreteClassB: PrimitiveOperation1");
        }

        protected override void PrimitiveOperation2()
        {
            Console.WriteLine("ConcreteClassB: PrimitiveOperation2");
        }
    }
}
