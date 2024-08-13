using DesignPatterns.AbstractFactory;
using DesignPatterns.Product;

namespace DesignPatterns
{
    /// <summary>
    /// 客戶端代碼
    /// </summary>
    public class Client
    {
        private readonly IProductA _productA;
        private readonly IProductB _productB;

        public Client(IAbstractFactory factory)
        {
            _productA = factory.CreateProductA();
            _productB = factory.CreateProductB();
        }

        public void Run()
        {
            _productA.DoSomething();
            _productB.DoSomething();
        }
    }
}
