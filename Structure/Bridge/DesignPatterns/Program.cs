using DesignPatterns.Bridge;

/// <summary>
/// Client code
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        IRenderer vectorRenderer = new VectorRenderer();
        IRenderer rasterRenderer = new RasterRenderer();

        Shape circle = new Circle(vectorRenderer, 5);
        circle.Draw();
        circle.Resize(2);
        circle.Draw();

        circle = new Circle(rasterRenderer, 5);
        circle.Draw();
        circle.Resize(2);
        circle.Draw();
    }
}
