# DesignPatterns.cs
C# 設計模式學習筆記與程式碼範例

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
又稱為最少知識原則（Principle of Least Knowledge）
鼓勵對象之間的松耦合關係
例如: 系統中有三個類：A、B和C。如果A的方法需要使用到C的功能，但A只能通過B來獲取C
A不應該直接調用C的方法
由B去調用C的方法
A只需要知道B提供的接口，而不需要知道C的存在，從而減少了系統的耦合度。
---

# git commit message
- 常用描述
```
✨ feat: 需求功能描述
🐛 fix: 修正 bug 的問題描述
💄 optimize: 最佳化程式碼或功能流程
🔧 chore: 雜事，例如: 調整設定檔案等等 
```
