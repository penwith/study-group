namespace ManyBeverages.Drinks
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Decaffeinated Coffee";
        }

        public override decimal Cost()
        {
            return 2.50M;
        }
    }
}