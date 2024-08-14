namespace DesignPatterns.State
{
    /// <summary>
    /// 具體狀態：關閉狀態
    /// </summary>
    public class OffState : ILightState
    {
        public void Handle(LightContext context)
        {
            Console.WriteLine("電燈已經關閉。");
            context.SetState(new OnState());
        }
    }
}
