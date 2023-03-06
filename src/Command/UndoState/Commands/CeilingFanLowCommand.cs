using UndoState.Receivers;

namespace UndoState.Commands
{
    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            _ceilingFan.Low();
        }
    }
}
