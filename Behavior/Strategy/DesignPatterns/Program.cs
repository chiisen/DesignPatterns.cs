using DesignPatterns.Strategy;

class Program
{
    static void Main(string[] args)
    {
        Context context = new Context(new OperationAdd());
        Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));

        context.SetStrategy(new OperationSubtract());
        Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));
    }
}
