在這個例子中，Bird是一個抽象基類，有一個Fly方法。
Sparrow（麻雀）和Ostrich（鴕鳥）是Bird的兩個子類。
按照LSP，
我們應該能夠將Bird的任何實例替換為它的子類Sparrow或Ostrich的實例，
而不影響程式的執行。
```c#
public abstract class Bird
{
    public abstract void Fly();
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        Console.WriteLine("麻雀在飛翔。");
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException("鴕鳥不能飛。");
    }
}

public class BirdManager
{
    public void MakeBirdFly(Bird bird)
    {
        bird.Fly();
    }
}
```
