using UndoState.Receivers;

namespace UndoState.Commands
{
    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            _ceilingFan.High();
        }
    }
}
