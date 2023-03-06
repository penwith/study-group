namespace UndoState.Commands
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
