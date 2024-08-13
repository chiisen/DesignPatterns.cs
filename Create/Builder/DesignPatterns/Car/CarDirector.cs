namespace DesignPatterns.Car
{
    /// <summary>
    /// 指揮者
    /// </summary>
    public class CarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void ConstructCar()
        {
            _builder.BuildEngine();
            _builder.BuildWheels();
            _builder.BuildBody();
        }
    }
}
