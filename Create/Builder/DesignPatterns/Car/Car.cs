namespace DesignPatterns.Car
{
    /// <summary>
    /// 產品類別
    /// </summary>
    public class Car
    {
        /// <summary>
        /// 
        /// </summary>
        public string? Engine { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Wheels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Body { get; set; }

        public override string ToString()
        {
            return $"Car with Engine: {Engine}, Wheels: {Wheels}, Body: {Body}";
        }
    }
}
