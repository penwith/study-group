using Macro;
using Macro.Commands;
using Macro.Receivers;

namespace Client
{
    public static class MacroDemo
    {
        public static void Run()
        {
            RemoteControl remote = new();

            var light = new Light("Living Room");
            var stereo = new Stereo("Living Room");
            var fondu = new Fondu("Dining Room");
            var hottub = new Hottub();

            // The Client creates a ConcreteCommand object and specifies its receiver
            ICommand lightOn = new LightOnCommand(light);
            ICommand lightOff = new LightOffCommand(light);

            ICommand stereoOn = new StereoOnCommand(stereo);
            ICommand stereoOff = new StereoOffCommand(stereo);

            ICommand fonduOn = new FonduOnCommand(fondu);
            ICommand fonduOff = new FonduOffCommand(fondu);

            ICommand hottubOn = new HottubOnHotCommand(hottub);
            ICommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, fonduOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, fonduOff, hottubOff };

            ICommand partyOnMacro = new MacroCommand(partyOn);
            ICommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(0, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);

            Console.WriteLine("--- Pushing Macro On ---");
            remote.OnButtonWasPushed(0);

            Console.WriteLine();
            Console.WriteLine("--- Pushing Macro Off ---");
            remote.OffButtonWasPushed(0);

            Console.WriteLine();
            Console.WriteLine("--- Pushing Undo ---");
            remote.UndoButtonWasPushed();

            Console.ReadKey();
        }
    }
}
