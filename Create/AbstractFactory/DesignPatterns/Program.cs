﻿using DesignPatterns.AbstractFactory;
using DesignPatterns;

/// <summary>
/// 測試程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        IAbstractFactory factory1 = new ConcreteFactory1();
        Client client1 = new Client(factory1);
        client1.Run();

        IAbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();
    }
}
