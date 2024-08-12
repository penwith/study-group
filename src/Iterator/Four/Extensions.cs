using Common;
using System.Collections;

namespace Four
{
    public static class Extensions
    {
        public static IEnumerator CreateIterator(this IMenu menu)
        {
            var enumerator = menu switch
            {
                DinerMenu dinerMenu => dinerMenu.GetMenuItems.GetEnumerator(),
                PancakeHouseMenu pancakeMenu => pancakeMenu.GetMenuItems.GetEnumerator(),
                CafeMenu cafeMenu => cafeMenu.GetMenuItems.Values.GetEnumerator(),
                _ => default!
            };

            return enumerator;
        }
    }
}
