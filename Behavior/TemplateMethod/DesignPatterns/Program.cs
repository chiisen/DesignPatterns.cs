using DesignPatterns.TemplateMethod;

class Program
{
    static void Main(string[] args)
    {
        AbstractClass classA = new ConcreteClassA();
        classA.TemplateMethod();

        Console.WriteLine();

        AbstractClass classB = new ConcreteClassB();
        classB.TemplateMethod();
    }
}
