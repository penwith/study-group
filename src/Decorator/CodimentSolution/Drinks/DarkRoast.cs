namespace Condiments.Drinks
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }

        public override decimal Cost()
        {
            return 2.70M + base.Cost();
        }
    }
}
