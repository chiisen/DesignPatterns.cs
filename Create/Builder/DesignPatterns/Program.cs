using DesignPatterns.Car;

/// <summary>
/// 客戶端代碼
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        ICarBuilder builder = new SportsCarBuilder();
        CarDirector director = new CarDirector(builder);

        director.ConstructCar();
        Car car = builder.GetCar();

        Console.WriteLine(car);
    }
}
