namespace Undo.Commands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
