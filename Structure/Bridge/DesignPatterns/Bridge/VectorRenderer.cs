namespace DesignPatterns.Bridge
{
    /// <summary>
    /// Concrete Implementor A
    /// </summary>
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radius)
        {
            Console.WriteLine($"Drawing a circle of radius {radius} with vectors.");
        }
    }
}
