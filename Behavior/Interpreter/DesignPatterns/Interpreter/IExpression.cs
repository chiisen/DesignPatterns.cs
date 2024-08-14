namespace DesignPatterns.Interpreter
{
    /// <summary>
    /// 定義一個抽象的表達式接口
    /// </summary>
    public interface IExpression
    {
        int Interpret(Dictionary<string, int> context);
    }
}
