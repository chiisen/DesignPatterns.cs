# DesignPatterns.cs
C# 設計模式學習筆記與程式碼範例

---

# 設計模式設計原則
## 單一職責原則 Single Responsibility Principle (SRP)
對於一個類別，只有一個引起變化的原因。
## 開放封閉原則 Open-Closed Principle (OCP)
對於擴充開放，對於修改封閉。
- 擴充是指不修改原有程式碼，只需添加新的程式碼，就能新增功能。
- 擴充通常指的是繼承、實現接口(interface)或多型(polymorphism)。

## 依賴反轉原則 Dependency Inversion Principle (DIP)
實作要依賴抽象，不要依賴具體類別。
- 抽象類別(abstract class)、接口(interface)、多型(polymorphism)是依賴反轉的三種方式。
- 依賴反轉的好處是降低耦合度，提高程式的可擴充性和可維護性。
[DIP 程式碼範例](./docs/DIP.md)

## 里式替換原則 Liskov Substitution Principle (LSP)
子類別必須能替換父類別，且不影響原有程式的功能。
[LSP 程式碼範例](./docs/LSP.md)

## 接口隔離原則 Interface Segregation Principle (ISP)
不依賴不使用的方法
使用接口如果有不使用的方法，應該要拆分出新的接口。
[ISP 程式碼範例](./docs/ISP.md)

## 迪米特法則 Law of Demeter (LoD)
又稱為最少知識原則（Principle of Least Knowledge），
勵對象之間的松耦合關係。

例如：
系統中有三個類:
A、B和C。如果A的方法需要使用到C的功能，但A只能通過B來獲取C
A不應該直接調用C的方法。
由B去調用C的方法。
A只需要知道B提供的接口，而不需要知道C的存在，從而減少了系統的耦合度。

---

# 創建型模式(Create)
設計模式 SimpleFactory、AbstractFactory、FactoryMethod 的差異為何?  
這三種設計模式都是用來創建對象的工廠模式，但它們在結構和用途上有所不同：  

1. **Simple Factory (簡單工廠模式)**：  
- [⭐ 簡單工廠(SimpleFactory)](./Create/SimpleFactory/SimpleFactory.sln)  
結構：由一個工廠類負責創建所有的產品對象。  
用途：當創建的對象較少且不需要擴展時使用。  
優點：簡單易用，適合小型應用。  
缺點：違反開放封閉原則，新增產品需要修改工廠類。  

2. **Factory Method (工廠方法模式)**：  
- [⭐ 工廠方法(FactoryMethod)](./Create//FactoryMethod/FactoryMethod.sln)  
結構：定義一個創建對象的接口，讓子類決定實例化哪一個類。  
工廠方法將實例化操作延遲到子類。  
用途：當創建的對象需要較多的變化且需要擴展時使用。  
優點：符合開放封閉原則，新增產品不需要修改現有代碼。  
缺點：增加了系統的複雜性，需要更多的類來管理。  

3. **Abstract Factory (抽象工廠模式)**：  
- [⭐ 抽象工廠(AbstractFactory)](./Create/AbstractFactory/AbstractFactory.sln)  
結構：提供一個創建一系列相關或相互依賴對象的接口，而無需指定它們具體的類。  
用途：當需要創建一組相關或依賴的對象時使用。  
優點：符合開放封閉原則，易於擴展，能夠創建一組相關的對象。  
缺點：增加了系統的複雜性，需要更多的類來管理。  

---

這些模式的選擇取決於具體的需求和應用場景。

---

[創建者模型(Builder)](./Create/Builder/Builder.sln)  
- Builder 可以讓你更靈活地構建複雜物件，並且可以很容易地擴展和修改構建過程。  

[原型模型(Prototype)](./Create/Prototype/Prototype.sln)  
- Prototype 模式允許你創建對象的複製，而不是通過直接實例化類來創建新對象。這在需要大量相似對象的情況下特別有用。  

[單例模型(Singleton)](./Create//Singleton/Singleton.sln)  

---

# 結構型模式(Structure)

[適配器模式(Adapter)](./Structure/Adapter/Adapter.sln)  
- 使用 Adapter 設計模式將一個類別的介面轉換為客戶端期望的另一個介面。  

橋接模式(Bridge)  
[組合模式(Composite)](./Structure/Composite/Composite.sln)  
- Composite 設計模式允許你將物件組合成樹狀結構來表示「部分-整體」的層次結構。這個模式讓客戶端可以統一地處理單個物件和物件的組合。  

[裝飾(者/器)模式(Decorator)](./Structure/Decorator/Decorator.sln)  
- 可以動態地給對象添加新的功能。  

[外觀/門面模式(Facade)](./Structure/Facade/Facade.sln)  
- 的是提供一個簡單的介面來訪問複雜子系統中的多個類別。這樣可以讓客戶端程式碼更容易使用和理解。  

[享元模式(Flyweight)](./Structure/Flyweight/Flyweight.sln)  
- 減少物件的數量，從而節省記憶體。  

[代理模式(Proxy)](./Structure/Proxy/Proxy.sln)  
- 可以在請求前後執行一些操作。  

---

# 行為型模式(Behavior)

觀察者模式(Observer)  
模板方法(TemplateMethod)  
命令模式(Command)  
狀態模式(State)  
責任鏈模式(Chain of Responsibility)  
解釋器模式(Interpreter)  
中介者模式(Mediator)  
訪問者模式(Visitor)  
備忘錄模式(Memento)  
迭代器模式(Iterator)  
策略模式(Strategy)  

---


# git commit message
- 常用描述
```
✨ feat: 需求功能描述
🐛 fix: 修正 bug 的問題描述
💄 optimize: 最佳化程式碼或功能流程
🔧 chore: 雜事，例如: 調整設定檔案等等 
```

---

