namespace DesignPatterns.Car
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildWheels();
        void BuildBody();
        Car GetCar();
    }
}
