namespace DesignPatterns.Command
{
    /// <summary>
    /// 4. 調用者類別
    /// 調用者類別負責存儲命令並在需要時執行它們。
    /// </summary>
    public class RemoteControl
    {
        private ICommand? _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void PressButton()
        { 
            if(_command != null)
            {
                _command.Execute();
            }
            else
            {
                Console.WriteLine("No command is set.");
            }
        }
    }
}
