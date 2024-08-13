namespace DesignPatterns.Flyweight
{
    /// <summary>
    /// Flyweight 工廠
    /// </summary>
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> circleMap = new Dictionary<string, IShape>();

        public static IShape GetCircle(string color)
        {
            Circle circle = null;
            if (circleMap.ContainsKey(color))
            {
                circle = (Circle)circleMap[color];
            }
            else
            {
                circle = new Circle(color);
                circleMap[color] = circle;
                Console.WriteLine($"Creating circle of color : {color}");
            }
            return circle;
        }
    }
}
