using Macro.Receivers;

namespace Macro.Commands
{
    public class StereoOffCommand : ICommand
    {
        private readonly Stereo _stereo;

        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _stereo.Off();
        }

        public void Undo()
        {
            _stereo.On();
        }
    }
}
