using Common;
using System.Collections;

namespace One
{
    public static class Demo1
    {
        /*
         * Two implementations - neither can change - how do we print a combined menu?
         *
         * Why is it an issue having two different collections?
         * We need code to iterate each type
         * What if we introduce a third, fourth... type?
         * We are coding to concrete implementations, not to an interface
         * What happens if we have to switch the type of collection?
         * Demo has to know how each menu represents it internal collection - violates encapsulation
         */

        public static void PrintMenu()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            ArrayList breakfastItems = pancakeHouseMenu.GetMenuItems;
            MenuItem[] lunchItems = dinerMenu.GetMenuItems;

            PrintMenu(breakfastItems, lunchItems);
        }

        private static void PrintMenu(ArrayList breakfastItems, MenuItem[] lunchItems)
        {
            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            for (var i = 0; i < breakfastItems.Count; i++)
            {
                var menuItem = breakfastItems[i] as MenuItem;
                PrintItem(menuItem);
            }

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            for (var i = 0; i < lunchItems.Length; i++)
            {
                var menuItem = lunchItems[i];
                PrintItem(menuItem);
            }
        }

        private static void PrintItem(MenuItem? menuItem)
        {
            if (menuItem == null) return;

            Console.WriteLine($"{menuItem.Name} - {menuItem.Price}");
            Console.WriteLine($" - {menuItem.Description}");
            Console.WriteLine();
        }
    }
}
