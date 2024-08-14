namespace DesignPatterns.Interpreter
{
    /// <summary>
    /// 減法表達式
    /// </summary>
    public class SubtractExpression : IExpression
    {
        private IExpression _leftExpression;
        private IExpression _rightExpression;

        public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
        {
            _leftExpression = leftExpression;
            _rightExpression = rightExpression;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            return _leftExpression.Interpret(context) - _rightExpression.Interpret(context);
        }
    }
}
