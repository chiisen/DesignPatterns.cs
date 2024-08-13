namespace DesignPatterns.Car
{
    /// <summary>
    /// 具體建造者
    /// </summary>
    public class SportsCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void BuildEngine()
        {
            _car.Engine = "V8 Engine";
        }

        public void BuildWheels()
        {
            _car.Wheels = "18 inch Alloy Wheels";
        }

        public void BuildBody()
        {
            _car.Body = "Sleek Body";
        }

        public Car GetCar()
        {
            return _car;
        }
    }
}
