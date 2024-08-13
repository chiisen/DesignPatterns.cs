namespace DesignPatterns.Prototype
{
    /// <summary>
    /// Concrete prototype class
    /// </summary>
    public class ConcretePrototype : IPrototype
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public ConcretePrototype(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Implement the Clone method
        public IPrototype Clone()
        {
            return new ConcretePrototype(Name, Age);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }
}
