using System.Text;

namespace Burgers
{
    public class Burger
    {
        public string Bun { get; set; }

        public string Patty { get; set; }

        public List<string> Extras { get; set; } = new();

        public List<string> Sides { get; set; } = new();

        public void Eat()
        {
            var sb = new StringBuilder("\n---------------------------")
                .AppendLine()
                .AppendLine($"Bun Type - {Bun}")
                .AppendLine($"Patty Type - {Patty}");

            Extras.ForEach(e => sb.AppendLine($"With extra {e}"));
            Sides.ForEach(s => sb.AppendLine($"And a side of {s}"));

            Console.WriteLine(sb.ToString());
        }
    }
}
