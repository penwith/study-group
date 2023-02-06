namespace RemoteSlots.Receivers
{
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage door is open");
        }

        public void Down()
        {
            Console.WriteLine("Garage door is closed");
        }

        public void Stop()
        {
            Console.WriteLine("Garage door stopped");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage light is on");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage light is off");
        }
    }
}
