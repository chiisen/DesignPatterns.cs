namespace DesignPatterns.Decorator
{
    /// <summary>
    /// Mocha 具體的裝飾者 
    /// </summary>
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage) { }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return beverage.Cost() + 0.20;
        }
    }
}
