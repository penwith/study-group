using Macro.Receivers;

namespace Macro.Commands
{
    public class FonduOffCommand : ICommand
    {
        private readonly Fondu _fondu;

        public FonduOffCommand(Fondu fondu)
        {
            _fondu = fondu;
        }

        public void Execute()
        {
            _fondu.Off();
        }

        public void Undo()
        {
            _fondu.On();
        }
    }
}
