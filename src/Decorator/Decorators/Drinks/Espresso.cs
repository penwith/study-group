namespace Decorators.Drinks
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            _description = "Espresso";
        }

        public override decimal Cost()
        {
            return 2.30M;
        }
    }
}