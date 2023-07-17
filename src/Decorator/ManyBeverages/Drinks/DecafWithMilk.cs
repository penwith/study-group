namespace ManyBeverages.Drinks
{
    public class DecafWithMilk : Beverage
    {
        public DecafWithMilk()
        {
            _description = "Decaffeinated Coffee with Milk";
        }

        public override decimal Cost()
        {
            return 2.50M + 0.30M;
        }
    }
}