namespace DesignPatterns.Interpreter
{
    /// <summary>
    /// 變量表達式
    /// </summary>
    public class VariableExpression : IExpression
    {
        private string _name;

        public VariableExpression(string name)
        {
            _name = name;
        }

        public int Interpret(Dictionary<string, int> context)
        {
            if (context.ContainsKey(_name))
            {
                return context[_name];
            }
            else
            {
                throw new ArgumentException($"變量 {_name} 未定義");
            }
        }
    }
}
