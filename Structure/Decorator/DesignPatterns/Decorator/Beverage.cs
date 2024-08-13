namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 定義一個抽象的組件
    /// </summary>
    public abstract class Beverage
    {
        public abstract string GetDescription();
        public abstract double Cost();
    }
}
