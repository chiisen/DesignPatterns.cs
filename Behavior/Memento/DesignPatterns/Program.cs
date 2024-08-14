using DesignPatterns.Memento;

/// <summary>
/// Client code
/// 展示如何使用這些類來保存和恢復狀態。
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        Caretaker caretaker = new Caretaker();

        originator.State = "State #1";
        originator.State = "State #2";
        caretaker.Add(originator.SaveStateToMemento());

        originator.State = "State #3";
        caretaker.Add(originator.SaveStateToMemento());

        originator.State = "State #4";
        Console.WriteLine("Current State: " + originator.State);

        originator.GetStateFromMemento(caretaker.Get(0));
        Console.WriteLine("First saved State: " + originator.State);
        originator.GetStateFromMemento(caretaker.Get(1));
        Console.WriteLine("Second saved State: " + originator.State);
    }
}
