namespace DesignPatterns.Component
{
    /// <summary>
    /// Component
    /// </summary>
    abstract class Component
    {
        protected string name;

        public Component(string name)
        {
            this.name = name;
        }

        public abstract void Display(int depth);
    }
}
