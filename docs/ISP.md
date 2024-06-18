假設我們有一個系統，其中包含打印機的功能。如果按照不遵循ISP的方式，我們可能會有一個包含多個方法的大接口：
```c#
public interface IMachine
{
    void Print(Document d);
    void Scan(Document d);
    void Fax(Document d);
}

public class MultiFunctionPrinter : IMachine
{
    public void Print(Document d)
    {
        // 實現打印
    }

    public void Scan(Document d)
    {
        // 實現掃描
    }

    public void Fax(Document d)
    {
        // 實現傳真
    }
}

public class OldFashionedPrinter : IMachine
{
    public void Print(Document d)
    {
        // 實現打印
    }

    public void Scan(Document d)
    {
        // 不支持掃描，可能拋出異常或空實現
    }

    public void Fax(Document d)
    {
        // 不支持傳真，可能拋出異常或空實現
    }
}
```
在這個例子中，OldFashionedPrinter類被迫實現它不需要的Scan和Fax方法，這違反了ISP原則。
為了遵循ISP，我們可以將IMachine接口拆分成幾個更小的接口：
```c#
public interface IPrinter
{
    void Print(Document d);
}

public interface IScanner
{
    void Scan(Document d);
}

public interface IFax
{
    void Fax(Document d);
}

// 對於支持所有功能的多功能打印機
public class MultiFunctionPrinter : IPrinter, IScanner, IFax
{
    public void Print(Document d)
    {
        // 實現打印
    }

    public void Scan(Document d)
    {
        // 實現掃描
    }

    public void Fax(Document d)
    {
        // 實現傳真
    }
}

// 對於只支持打印的老式打印機
public class OldFashionedPrinter : IPrinter
{
    public void Print(Document d)
    {
        // 實現打印
    }
}
```
