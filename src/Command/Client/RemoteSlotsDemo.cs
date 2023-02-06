using RemoteSlots;
using RemoteSlots.Commands;
using RemoteSlots.Receivers;

namespace Client
{
    public static class RemoteSlotsDemo
    {
        public static void Run()
        {
            RemoteControl remote = new();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var heating = new Heating();
            var avAmp = new AvAmplifier();

            // The Client creates a ConcreteCommand object and specifies its receiver
            ICommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            ICommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            ICommand kitchenLightOn = new LightOnCommand(kitchenLight);
            ICommand kitchenLightOff = new LightOffCommand(kitchenLight);

            ICommand heatingOn = new HeatingOnCommand(heating);
            ICommand heatingOff = new HeatingOffCommand(heating);

            ICommand avOnWithSpotify = new AvOnWithSpotifyCommand(avAmp);
            ICommand avOff = new AvOffCommand(avAmp);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remote.SetCommand(2, heatingOn, heatingOff);
            remote.SetCommand(3, avOnWithSpotify, avOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);

            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);

            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);

            remote.OnButtonWasPushed(3);
            remote.OffButtonWasPushed(3);

            Console.ReadKey();
        }
    }
}
