using LambdaRemote;
using LambdaRemote.Receivers;

namespace Client
{
    public static class LambdaRemoteDemo
    {
        public static void Run()
        {
            RemoteControl remote = new();

            var livingRoomLight = new Light("Living Room");
            var kitchenLight = new Light("Kitchen");
            var heating = new Heating();
            var avAmp = new AvAmplifier();

            // The Client creates a ConcreteCommand object and specifies its receiver
            // ??!

            remote.SetCommand(0, () => livingRoomLight.On(), () => livingRoomLight.Off());
            remote.SetCommand(1, () => kitchenLight.On(), () => kitchenLight.Off());
            remote.SetCommand(2, () => heating.On(), () => heating.Off());

            remote.SetCommand(3,
                () =>
                {
                    avAmp.On();
                    avAmp.SetSpotify();
                    avAmp.SetVolume(11);
                },
                () =>
                {
                    avAmp.Off();
                });

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
