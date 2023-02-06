using RemoteSlots.Receivers;

namespace RemoteSlots.Commands
{
    public  class AvOffCommand : ICommand
    {
        private readonly AvAmplifier _amp;

        public AvOffCommand(AvAmplifier amp)
        {
            _amp = amp;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _amp.Off();
        }
    }
}
