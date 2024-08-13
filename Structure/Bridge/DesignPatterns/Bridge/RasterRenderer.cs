namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Concrete Implementor B
    /// </summary>
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} with pixels.");
        }
    }
}
