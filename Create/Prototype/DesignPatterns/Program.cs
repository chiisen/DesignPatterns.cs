using DesignPatterns.Prototype;

class Program
{
    static void Main(string[] args)
    {
        // Create an original object
        ConcretePrototype original = new ConcretePrototype("John Doe", 30);
        Console.WriteLine("Original: " + original);

        // Clone the original object
        ConcretePrototype clone = (ConcretePrototype)original.Clone();
        Console.WriteLine("Clone: " + clone);

        // Modify the clone
        clone.Name = "Jane Doe";
        clone.Age = 25;
        Console.WriteLine("Modified Clone: " + clone);

        // Original object remains unchanged
        Console.WriteLine("Original after clone modification: " + original);
    }
}
