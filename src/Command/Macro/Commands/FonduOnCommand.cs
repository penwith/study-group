using Macro.Receivers;

namespace Macro.Commands
{
    public class FonduOnCommand : ICommand
    {
        private readonly Fondu _fondu;

        public FonduOnCommand(Fondu fondu)
        {
            _fondu = fondu;
        }

        public void Execute()
        {
            _fondu.On();
        }

        public void Undo()
        {
            _fondu.Off();
        }
    }
}
