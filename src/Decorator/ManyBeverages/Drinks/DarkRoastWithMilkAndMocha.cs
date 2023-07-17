namespace ManyBeverages.Drinks
{
    public class DarkRoastWithMilkAndMocha : Beverage
    {
        public DarkRoastWithMilkAndMocha()
        {
            _description = "Dark Roast with Milk and Mocha";
        }

        public override decimal Cost()
        {
            return 2.70M + 0.30M + 0.60M;
        }
    }
}
