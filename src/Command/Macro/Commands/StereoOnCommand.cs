using Macro.Receivers;

namespace Macro.Commands
{
    public class StereoOnCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOnCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _stereo.On();
        }

        public void Undo()
        {
            _stereo.Off();
        }
    }
}
