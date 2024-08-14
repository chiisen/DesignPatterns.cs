using DesignPatterns.Interpreter;

class Program
{
    static void Main(string[] args)
    {
        // 建立變量上下文
        var context = new Dictionary<string, int>
        {
            { "x", 5 },
            { "y", 10 }
        };

        // 建立表達式
        IExpression expression = new AddExpression(
            new VariableExpression("x"),
            new SubtractExpression(
                new ConstantExpression(20),
                new VariableExpression("y")
            )
        );

        // 解釋並計算表達式
        int result = expression.Interpret(context);
        Console.WriteLine($"結果: {result}"); // 輸出結果: 15
    }
}
