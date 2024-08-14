using DesignPatterns.Chain_of_Responsibility;

class Program
{
    static void Main(string[] args)
    {
        // 設定責任鏈
        Handler h1 = new ConcreteHandler1();
        Handler h2 = new ConcreteHandler2();
        Handler h3 = new ConcreteHandler3();
        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);

        // 生成並處理請求
        int[] requests = { 5, 14, 22, 18, 3, 27, 20 };

        foreach (int request in requests)
        {
            h1.HandleRequest(request);
        }
    }
}
