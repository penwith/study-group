using Remote;
using Remote.Commands;
using Remote.Receivers;

namespace Client
{
    public static class RemoteDemo
    {
        public static void Run()
        {
            Light light = new();
            GarageDoor garageDoor = new();
            
            // The Client creates a ConcreteCommand object and specifies its receiver
            LightOnCommand lightOn = new(light);
            GarageDoorOpenCommand garageOpen = new(garageDoor);

            RemoteControl remote = new();

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();

            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();

            Console.ReadKey();
        }
    }
}
