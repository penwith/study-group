namespace Systems
{
    public class SystemFactory
    {
        public Amplifier Amplifier() { return new Amplifier(); }

        public Blinds Blinds() { return new Blinds(); }

        public Player DvPlayer() { return new DvdPlayer(); }

        public Lights Lights() { return new Lights(); }

        public PopcornPopper PopcornPopper() { return new PopcornPopper(); }

        public Projector Projector() { return new Projector();  }

        public Screen Screen() { return new Screen(); }

        public Player StreamingPlayer() { return new StreamingPlayer(); }
    }
}
