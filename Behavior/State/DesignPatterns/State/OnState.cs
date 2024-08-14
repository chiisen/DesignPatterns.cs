namespace DesignPatterns.State
{
    /// <summary>
    /// 具體狀態：開啟狀態
    /// </summary>
    public class OnState : ILightState
    {
        public void Handle(LightContext context)
        {
            Console.WriteLine("電燈已經開啟。");
            context.SetState(new OffState());
        }
    }
}
