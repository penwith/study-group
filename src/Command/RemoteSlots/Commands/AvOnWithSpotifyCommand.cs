using RemoteSlots.Receivers;

namespace RemoteSlots.Commands
{
    public class AvOnWithSpotifyCommand : ICommand
    {
        private readonly AvAmplifier _amp;

        public AvOnWithSpotifyCommand(AvAmplifier amp)
        {
            _amp = amp;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _amp.On();
            _amp.SetSpotify();
            _amp.SetVolume(11);
        }
    }
}
