using DesignPatterns.Command;

class Program
{
    static void Main(string[] args)
    {
        // 創建接收者
        Light livingRoomLight = new Light();

        // 創建具體命令
        ICommand lightOn = new LightOnCommand(livingRoomLight);
        ICommand lightOff = new LightOffCommand(livingRoomLight);

        // 創建調用者
        var remote = new RemoteControl();

        // 設置並執行命令
        remote.SetCommand(lightOn);
        remote.PressButton();

        remote.SetCommand(lightOff);
        remote.PressButton();
    }
}
