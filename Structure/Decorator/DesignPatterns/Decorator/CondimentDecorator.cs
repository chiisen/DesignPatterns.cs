namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 抽象的裝飾者
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        protected Beverage beverage;

        public CondimentDecorator(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription();
        }

        public override double Cost()
        {
            return beverage.Cost();
        }
    }
}
