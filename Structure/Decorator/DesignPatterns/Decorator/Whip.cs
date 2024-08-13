namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Whip 具體的裝飾者 
    /// </summary>
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.30;
        }
    }
}
