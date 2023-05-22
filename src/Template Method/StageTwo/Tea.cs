namespace StageTwo
{
    public class Tea : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea (y/n)?");
            var input = Console.ReadLine();
            return input.ToLower().StartsWith('y');
        }
    }
}
