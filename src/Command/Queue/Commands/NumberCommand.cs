namespace Queue.Commands
{
    public class NumberCommand : ICommand
    {
        private readonly int _number;

        public NumberCommand(int number)
        {
            _number = number;
        }

        public void Execute(string identifier)
        {
            Console.WriteLine($"Client id {identifier} is processing number {_number}");
        }
    }
}
