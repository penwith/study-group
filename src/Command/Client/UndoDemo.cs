using Undo;
using Undo.Commands;
using Undo.Receivers;

namespace Client
{
    public class UndoDemo
    {
        public static void Run()
        {
            RemoteControl remote = new();

            var livingRoomLight = new Light("Living Room");

            // The Client creates a ConcreteCommand object and specifies its receiver
            ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(0);

            Console.WriteLine(remote);

            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();
            remote.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
