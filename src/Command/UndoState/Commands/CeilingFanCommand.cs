using UndoState.Receivers;

namespace UndoState.Commands
{
    public abstract class CeilingFanCommand : ICommand
    {
        private Speed _previousSpeed;
        protected readonly CeilingFan _ceilingFan;

        protected CeilingFanCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _previousSpeed = _ceilingFan.GetSpeed();
            SetSpeed();
        }

        protected abstract void SetSpeed();

        public void Undo()
        {
            switch (_previousSpeed)
            {
                case Speed.Off:
                    _ceilingFan.Off();
                    break;
                case Speed.Low:
                    _ceilingFan.Low();
                    break;
                case Speed.Medium:
                    _ceilingFan.Medium();
                    break;
                case Speed.High:
                    _ceilingFan.High();
                    break;
            }
        }
    }
}
