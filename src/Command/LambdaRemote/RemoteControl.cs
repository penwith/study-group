using System.Text;

namespace LambdaRemote
{
    public class RemoteControl
    {
        private const int Size = 7;

        private readonly Action[] _onCommands;
        private readonly Action[] _offCommands;

        public RemoteControl()
        {
            _onCommands = new Action[Size];
            _offCommands = new Action[Size];

            for (var i = 0; i < Size; i++)
            {
                _onCommands[i] = () => { };
                _offCommands[i] = () => { };
            }
        }

        // An Invoker object stores the ConcreteCommand object
        public void SetCommand(int slot, Action onCommand, Action offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        // The Invoker issues a request by calling Execute on the command.
        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Invoke();
        }

        // The Invoker issues a request by calling Execute on the command.
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Invoke();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var onCommands = _onCommands.Select(c => c.GetType().Name).ToList();
            var offCommands = _offCommands.Select(c => c.GetType().Name).ToList();

            var maxLength = onCommands.OrderByDescending(s => s.Length).First().Length + 2;

            sb.AppendLine("------- Remote Control -------");

            for (var i = 0; i < Size; i++)
            {
                sb.AppendLine($"[Slot {i}]  {onCommands[i].PadRight(maxLength)}{offCommands[i].PadRight(maxLength)}");
            }

            return sb.ToString();
        }
    }
}
