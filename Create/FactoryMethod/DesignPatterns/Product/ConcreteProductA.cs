namespace DesignPatterns.Product
{
    /// <summary>
    /// 具體產品 A
    /// </summary>
    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation of ConcreteProductA");
        }
    }
}
