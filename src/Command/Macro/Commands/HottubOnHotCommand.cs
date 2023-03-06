using Macro.Receivers;

namespace Macro.Commands
{
    public class HottubOnHotCommand : ICommand
    {
        private readonly Hottub _hottub;

        public HottubOnHotCommand(Hottub hottub)
        {
            _hottub = hottub;
        }

        public void Execute()
        {
            _hottub.Heat(43);
            _hottub.JetsOn();
        }

        public void Undo()
        {
            _hottub.Off();
        }
    }
}
