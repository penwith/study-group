namespace StageTwo
{
    public class Coffee : Beverage
    {
        protected override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like milk and sugar with your coffee (y/n)?");
            var input = Console.ReadLine();
            return input.ToLower().StartsWith('y');
        }
    }
}
