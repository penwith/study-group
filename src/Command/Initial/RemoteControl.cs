using Remote.Commands;

namespace Remote
{
    public class RemoteControl
    {
        private ICommand? _command;

        // An Invoker object stores the ConcreteCommand object
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        // The Invoker issues a request by calling Execute on the command.
        public void ButtonWasPressed()
        {
            _command?.Execute();
        }
    }
}
