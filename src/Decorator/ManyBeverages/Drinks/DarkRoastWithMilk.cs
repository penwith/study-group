namespace ManyBeverages.Drinks
{
    public class DarkRoastWithMilk : Beverage
    {
        public DarkRoastWithMilk()
        {
            _description = "Dark Roast with Milk";
        }

        public override decimal Cost()
        {
            return 2.70M + 0.30M;
        }
    }
}
