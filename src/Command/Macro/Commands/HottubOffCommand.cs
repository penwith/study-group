using Macro.Receivers;

namespace Macro.Commands
{
    public class HottubOffCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOffCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.Off();
        }

        public void Undo()
        {
            _hottub.Heat(43);
            _hottub.JetsOn();
        }
    }
}
