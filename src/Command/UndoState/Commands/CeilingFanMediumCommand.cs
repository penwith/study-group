using UndoState.Receivers;

namespace UndoState.Commands
{
    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            _ceilingFan.Medium();
        }
    }
}
