using System.Collections;
using Common;
using Three;

namespace Four
{
    public class Demo4
    {
        public static void PrintMenu()
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();
            IMenu cafeMenu = new CafeMenu();

            IEnumerator pancakeEnumerator = pancakeHouseMenu.CreateIterator();
            IEnumerator dinerEnumerator = dinerMenu.CreateIterator();
            IEnumerator cafeEnumerator = cafeMenu.CreateIterator();

            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            PrintMenu(pancakeEnumerator);

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            PrintMenu(dinerEnumerator);

            Console.WriteLine();
            Console.WriteLine("DINNER");
            Console.WriteLine();

            PrintMenu(cafeEnumerator);
        }

        private static void PrintMenu(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                if (enumerator.Current is not MenuItem menuItem) return;

                Console.WriteLine($"{menuItem.Name} - {menuItem.Price}");
                Console.WriteLine($" - {menuItem.Description}");
                Console.WriteLine();
            }
        }
    }
}
