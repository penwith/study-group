namespace Macro.Receivers
{
    public class Hottub
    {
        public void Heat(int temp)
        {
            Console.WriteLine($"Hottub is heating to {temp} degrees");
        }

        public void JetsOn()
        {
            Console.WriteLine($"Hottub is bubbling");
        }

        public void Off()
        {
            Console.WriteLine($"Hottub is off");
        }
    }
}
