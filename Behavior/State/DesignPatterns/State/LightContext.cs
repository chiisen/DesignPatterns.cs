namespace DesignPatterns.State
{
    /// <summary>
    /// 上下文類別
    /// </summary>
    public class LightContext
    {
        private ILightState _state;

        public LightContext(ILightState state)
        {
            _state = state;
        }

        public void SetState(ILightState state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
