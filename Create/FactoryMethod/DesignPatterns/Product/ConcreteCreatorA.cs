namespace DesignPatterns.Product
{
    /// <summary>
    /// 具體創建者 A
    /// </summary>
    public class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }
}
