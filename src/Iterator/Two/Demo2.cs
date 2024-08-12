using Common;

namespace Two
{
    public  class Demo2
    {
        /*
         * Can we encapsulate the iteration?
         * Can we create an object that encapsulates the way we iterate through a collection of objects?
         *
         * With the IIterator interface we can implement iterators for any kind of collection of objects - arrays, lists, hashtables, etc...
         * Collection meaning any group of objects - also called AGGREGATES
         * Each menu can keep its implementation - just add iterators and this process no longer needs to understand the internal implementations of those menus
         * Making this easier to maintain and extend
         * Menu implementations are now encapsulated
         * Now using polymorphic loop
         * We are still bound to concrete menu classes
         */

        public static void PrintMenu()
        {
            var pancakeHouseMenu = new PancakeHouseMenu();
            var dinerMenu = new DinerMenu();

            IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = dinerMenu.CreateIterator();

            Console.WriteLine("BREAKFAST");
            Console.WriteLine();

            PrintMenu(pancakeIterator);

            Console.WriteLine();
            Console.WriteLine("LUNCH");
            Console.WriteLine();

            PrintMenu(dinerIterator);
        }

        private static void PrintMenu(IIterator iterator)
        {
            while (iterator.HasNext)
            {
                var menuItem = iterator.Next as MenuItem;

                Console.WriteLine($"{menuItem.Name} - {menuItem.Price}");
                Console.WriteLine($" - {menuItem.Description}");
                Console.WriteLine();
            }
        }
    }
}
