using DesignPatterns.Product;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// 抽象工廠
    /// </summary>
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }

}
