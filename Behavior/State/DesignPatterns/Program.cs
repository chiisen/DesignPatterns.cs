using DesignPatterns.State;

/// <summary>
/// 測試程式
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        LightContext context = new LightContext(new OffState());

        // 切換狀態
        context.Request(); // 電燈已經關閉。
        context.Request(); // 電燈已經開啟。
        context.Request(); // 電燈已經關閉。
        context.Request(); // 電燈已經開啟。
    }
}
