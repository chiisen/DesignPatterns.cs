namespace DesignPatterns.Command
{
    /// <summary>
    /// 3. 接收者類別
    /// 接收者類別包含實際執行命令的邏輯。
    /// </summary>
    public class Light
    {
        public void On()
        {
            Console.WriteLine("The light is on.");
        }

        public void Off()
        {
            Console.WriteLine("The light is off.");
        }
    }
}
