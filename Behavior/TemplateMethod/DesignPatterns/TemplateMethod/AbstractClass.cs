namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// 抽象類別，定義算法骨架
    /// </summary>
    abstract class AbstractClass
    {
        // 模板方法，定義算法的骨架
        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
            ConcreteOperation();
        }

         /// <summary>
        /// 基本操作，必須由子類實現
        /// </summary>
        protected abstract void PrimitiveOperation1();
        protected abstract void PrimitiveOperation2();

        /// <summary>
        /// 具體操作，子類可以選擇性地重寫
        /// </summary>
        protected virtual void ConcreteOperation()
        {
            Console.WriteLine("AbstractClass: ConcreteOperation");
        }
    }
}
