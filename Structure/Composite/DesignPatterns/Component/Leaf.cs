namespace DesignPatterns.Component
{
    /// <summary>
    /// Leaf
    /// </summary>
    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
