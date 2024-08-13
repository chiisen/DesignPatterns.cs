namespace DesignPatterns.Product
{
    /// <summary>
    /// 具體創建者 B
    /// </summary>
    public class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }
}
