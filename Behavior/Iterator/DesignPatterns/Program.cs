using DesignPatterns.Iterator;

class Program
{
    static void Main(string[] args)
    {
        ConcreteCollection collection = new ConcreteCollection();
        collection[0] = "Item A";
        collection[1] = "Item B";
        collection[2] = "Item C";

        Iterator iterator = (Iterator)collection.CreateIterator();

        Console.WriteLine("Iterating over collection:");

        if(iterator == null)
        {
            throw new ArgumentNullException(nameof(iterator));
        }
        object? item = iterator.First();
        while (!iterator.IsDone)
        {
            Console.WriteLine(item);
            item = iterator.Next();
        }
    }
}
