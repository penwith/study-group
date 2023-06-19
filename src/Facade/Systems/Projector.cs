namespace Systems
{
    public class Projector
    {
        public void On()
        {
            Console.WriteLine("Projector on");
        }

        public void Off()
        {
            Console.WriteLine("Projector off");
        }

        public void TvMode()
        {
            Console.WriteLine("Projector in TV mode (16:9 aspect ratio)");
        }

        public void MovieMode()
        {
            Console.WriteLine("Projector in cinematic widescreen mode (21:9 aspect ratio)");
        }
    }
}
