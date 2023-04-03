using UndoState;
using UndoState.Commands;
using UndoState.Receivers;

namespace Client
{
    public static class UndoStateDemo
    {
        public static void Run()
        {
            RemoteControl remote = new();

            var livingRoomLight = new CeilingFan("Living Room");

            // The Client creates a ConcreteCommand object and specifies its receiver
            ICommand ceilingFanOff = new CeilingFanOffCommand(livingRoomLight);
            ICommand ceilingFanLow = new CeilingFanLowCommand(livingRoomLight);
            ICommand ceilingFanMedium = new CeilingFanMediumCommand(livingRoomLight);
            ICommand ceilingFanHigh = new CeilingFanHighCommand(livingRoomLight);

            remote.SetCommand(0, ceilingFanLow, ceilingFanOff);
            remote.SetCommand(1, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(2, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);

            Console.WriteLine(remote);

            Console.WriteLine("Undo...");
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(2);

            Console.WriteLine(remote);

            Console.WriteLine("Undo...");
            remote.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
