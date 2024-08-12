using System.Collections;
using Common;

namespace Three
{
    public class Demo3
    {
        /*
         * Demo is still closely coupled with menu types, also
         * In C# we have IEnumerable and IEnumerator
         *
         * We are still newing up our menus, but that's because I'm lazy
         * Imaging instead we are using DI, and/or using a factory
         *
         * Now we have reduced dependencies and our code is loosely coupled
         */

        public static void PrintMenu()
        {
            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu dinerMenu = new DinerMenu();

            IEnumerator pancakeEnumerator = pancakeHouseMenu.CreateIterator();
            IEnumerator dinerEnumerator = dinerMenu.CreateIterator();

            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            PrintMenu(pancakeEnumerator);

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            PrintMenu(dinerEnumerator);
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

        public static void StillExposingTheUnderlyingRepresentations()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            var pancakeEnumerator = pancakeHouseMenu.GetMenuItems.GetEnumerator();
            var dinerEnumerator = dinerMenu.GetMenuItems.GetEnumerator();

            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            PrintMenu(pancakeEnumerator);

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            PrintMenu(dinerEnumerator);
        }
    }
}
