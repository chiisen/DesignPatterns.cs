using DesignPatterns.Observer;

class Program
{
    static void Main()
    {
        ConcreteSubject subject = new ConcreteSubject();

        ConcreteObserver observer1 = new ConcreteObserver("Observer 1");
        ConcreteObserver observer2 = new ConcreteObserver("Observer 2");

        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);

        subject.State = "State 1";
        subject.State = "State 2";

        subject.RemoveObserver(observer1);

        subject.State = "State 3";
    }
}
