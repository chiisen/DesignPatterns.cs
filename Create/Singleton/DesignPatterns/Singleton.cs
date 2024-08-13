namespace DesignPatterns
{
    public sealed class Singleton
    {
        // 靜態變數來保存類別的唯一實例
        private static readonly Singleton instance = new();

        // 私有建構函數，防止外部實例化
        private Singleton()
        {
        }

        // 公共靜態方法來獲取唯一實例
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }

        // 其他成員方法
        public void SomeMethod()
        {
            // 實作一些功能
            Console.WriteLine("Singleton instance method called.");
        }
    }
}
