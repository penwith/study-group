namespace Queue.Commands
{
    public class StringCommand : ICommand
    {
        private readonly string _number;

        public StringCommand(string number)
        {
            _number = number;
        }

        public void Execute(string identifier)
        {
            Console.WriteLine($"Client id {identifier} is processing string {_number}");
        }
    }
}
