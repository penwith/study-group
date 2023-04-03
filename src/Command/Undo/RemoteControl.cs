using System.Text;
using Undo.Commands;

namespace Undo
{
    public class RemoteControl
    {
        private const int Size = 7;

        private readonly ICommand[] _onCommands;
        private readonly ICommand[] _offCommands;

        private ICommand _undoCommand;

        public RemoteControl()
        {
            _onCommands = new ICommand[Size];
            _offCommands = new ICommand[Size];

            ICommand noCommand = new NoCommand();

            for (var i = 0; i < Size; i++)
            {
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        // An Invoker object stores the ConcreteCommand object
        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        // The Invoker issues a request by calling Execute on the command.
        public void OnButtonWasPushed(int slot)
        {
            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }

        // The Invoker issues a request by calling Execute on the command.
        public void OffButtonWasPushed(int slot)
        {
            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        // The Invoker issues a request by calling Execute on the command.
        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            var onCommands = _onCommands.Select(c => c.GetType().Name).ToList();
            var offCommands = _offCommands.Select(c => c.GetType().Name).ToList();

            var maxLength = onCommands.OrderByDescending(s => s.Length).First().Length + 2;

            sb.AppendLine();
            sb.AppendLine("------- Remote Control -------");

            for (var i = 0; i < Size; i++)
            {
                sb.AppendLine($"[Slot {i}]  {onCommands[i].PadRight(maxLength)}{offCommands[i].PadRight(maxLength)}");
            }

            sb.AppendLine($"[Undo]    {_undoCommand.GetType().Name}");

            return sb.ToString();
        }
    }
}