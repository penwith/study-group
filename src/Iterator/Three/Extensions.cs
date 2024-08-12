using Common;
using System.Collections;

namespace Three
{
    public static class Extensions
    {
        // Both Array and ArrayList have an enumerator
        // So we do not have to implement our own

        // This is not a great way to implement CreateIterator
        // I started with the menus in common and didn't want to have to duplicate them

        public static IEnumerator CreateIterator(this IMenu menu)
        {
            IEnumerator enumerator = default!;

            if (menu is DinerMenu dinerMenu)
            {
                enumerator = dinerMenu.GetMenuItems.GetEnumerator();
            }
            else if (menu is PancakeHouseMenu pancakeMenu)
            {
                enumerator = pancakeMenu.GetMenuItems.GetEnumerator();
            }

            return enumerator;
        }
    }
}
