namespace DesignPatterns.Flyweight
{
    // 客戶端程式碼
    public class FlyweightPatternDemo
    {
        private static readonly string[] colors = { "Red", "Green", "Blue", "White", "Black" };

        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle = (Circle)ShapeFactory.GetCircle(GetRandomColor());
                circle.SetX(GetRandomX());
                circle.SetY(GetRandomY());
                circle.SetRadius(100);
                circle.Draw();
            }
        }

        private static string GetRandomColor()
        {
            Random random = new Random();
            return colors[random.Next(colors.Length)];
        }

        private static int GetRandomX()
        {
            Random random = new Random();
            return random.Next(100);
        }

        private static int GetRandomY()
        {
            Random random = new Random();
            return random.Next(100);
        }
    }
}
