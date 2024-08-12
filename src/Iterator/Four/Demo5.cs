using Common;
using System.Collections;

namespace Four
{
    public class Demo5
    {
        /*
         * So why not just use the idiomatic foreach built into C#?
         */

        public static void PrintMenu()
        {
            // Tightly coupled - no polymorphic behaviour
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();
            var cafeMenu = new CafeMenu();

            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            // Need to understand the inner workings to know we must cast
            foreach (MenuItem menuItem in pancakeHouseMenu.GetMenuItems)
            {
                PrintItem(menuItem);
            }

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            // We still have to have access to the inner working of the aggregate
            foreach (var menuItem in dinerMenu.GetMenuItems)
            {
                PrintItem(menuItem);
            }

            Console.WriteLine();
            Console.WriteLine("DINNER");
            Console.WriteLine();

            // Where did DictionaryEntry come from?!
            foreach (DictionaryEntry menuItem in cafeMenu.GetMenuItems)
            {
                PrintItem(menuItem.Value as MenuItem);
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
