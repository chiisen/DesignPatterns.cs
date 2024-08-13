namespace DesignPatterns.Product
{
    /// <summary>
    /// 創建者抽象類別
    /// </summary>
    public abstract class Creator
    {
        /// <summary>
        /// 工廠方法
        /// </summary>
        /// <returns></returns>
        public abstract IProduct FactoryMethod();

        /// <summary>
        /// 一些操作
        /// </summary>
        public void SomeOperation()
        {
            var product = FactoryMethod();
            product.Operation();
        }
    }
}
