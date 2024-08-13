namespace DesignPatterns.Decorator
{
    /// <summary>
    /// 具體的組件
    /// </summary>
    public class Espresso : Beverage
    {
        public override string GetDescription()
        {
            return "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
