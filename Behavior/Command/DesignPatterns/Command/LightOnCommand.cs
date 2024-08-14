namespace DesignPatterns.Command
{
    /// <summary>
    /// 2. 具體命令類別 - LightOnCommand
    /// 這些類別將實現 ICommand 介面。
    /// </summary>
    public class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.On();
        }
    }
}
