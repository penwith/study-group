using RemoteSlots.Receivers;

namespace RemoteSlots.Commands
{
    public class HeatingOffCommand : ICommand
    {
        private readonly Heating _heating;

        public HeatingOffCommand(Heating heating)
        {
            _heating = heating;
        }

        // The ConcreteCommand object invokes operations on its receiver to carry out the request
        public void Execute()
        {
            _heating.Off();
        }
    }
}
