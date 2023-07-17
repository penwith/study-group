namespace Condiments.Drinks
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "decaffeinated coffee";
        }

        public override decimal Cost()
        {
            return 2.50M + base.Cost();
        }
    }
}