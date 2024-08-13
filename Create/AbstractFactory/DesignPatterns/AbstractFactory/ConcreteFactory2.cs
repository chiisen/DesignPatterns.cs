using DesignPatterns.Product;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 具體工廠2
    /// </summary>
    public class ConcreteFactory2 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
