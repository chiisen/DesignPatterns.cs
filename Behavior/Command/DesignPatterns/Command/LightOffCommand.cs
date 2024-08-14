namespace DesignPatterns.Command
{
    /// <summary>
    /// 2. 具體命令類別 - LightOffCommand
    /// 這些類別將實現 ICommand 介面。
    /// </summary>
    public class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.Off();
        }
    }
}
