using System;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// 1. 定義 Subject 介面
    /// </summary>
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }
}
