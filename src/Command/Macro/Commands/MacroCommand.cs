namespace Macro.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            for (var i = 0; i < _commands.Length; i++)
            {
                _commands[i].Execute();
            }
        }

        public void Undo()
        {
            for (var i = 0; i < _commands.Length; i++)
            {
                _commands[i].Undo();
            }
        }
    }
}
