namespace Queue.Commands
{
    public interface ICommand
    {
        void Execute(string identifier);
    }
}
