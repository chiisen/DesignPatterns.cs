namespace DesignPatterns.Interpreter
{
    /// <summary>
    /// 常量表達式
    /// </summary>
    public class ConstantExpression : IExpression
    {
        private int _value;

        public ConstantExpression(int value)
        {
            _value = value;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _value;
        }
    }
}
