using UndoState.Receivers;

namespace UndoState.Commands
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan) : base(ceilingFan) { }

        protected override void SetSpeed()
        {
            _ceilingFan.Off();
        }
    }
}
