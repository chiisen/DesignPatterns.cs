namespace DesignPatterns.State
{
    /// <summary>
    /// 定義狀態介面
    /// </summary>
    public interface ILightState
    {
        void Handle(LightContext context);
    }

}
