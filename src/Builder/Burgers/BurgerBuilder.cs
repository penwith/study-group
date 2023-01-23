namespace Burgers
{
    public class BurgerBuilder
    {
        private readonly string _bun;
        private readonly string _patty;

        private readonly List<string> _extras = new();
        private readonly List<string> _sides = new();

        public BurgerBuilder(string bun, string patty)
        {
            _bun = bun;
            _patty = patty;
        }

        public static BurgerBuilder Init(string bun, string patty)
        {
            return new BurgerBuilder(bun, patty);
        }

        public BurgerBuilder WithExtra(string extra)
        {
            _extras.Add(extra);
            return this;
        }

        public BurgerBuilder WithSide(string side)
        {
            _sides.Add(side);
            return this;
        }

        public Burger Build()
        {
            return new Burger
            {
                Bun = _bun,
                Patty = _patty,
                Extras = _extras,
                Sides = _sides
            };
        }
    }
}
