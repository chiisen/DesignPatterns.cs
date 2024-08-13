using DesignPatterns.Decorator;

/// <summary>
/// 使用範例
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        Beverage beverage = new Espresso();
        Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

        beverage = new Mocha(beverage);
        Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

        beverage = new Whip(beverage);
        Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());
    }
}
