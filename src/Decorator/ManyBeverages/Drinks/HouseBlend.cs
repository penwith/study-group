namespace ManyBeverages.Drinks
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend";
        }

        public override decimal Cost()
        {
            return 2.50M;
        }
    }
}
