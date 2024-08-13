using DesignPatterns.Product;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 具體工廠1
    /// </summary>
    public class ConcreteFactory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
