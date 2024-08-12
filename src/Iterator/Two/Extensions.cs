using Common;

namespace Two
{
    public static class Extensions
    {
        public static IIterator CreateIterator(this DinerMenu menu)
        {
            return new DinerMenuIterator(menu.GetMenuItems);
        }

        public static IIterator CreateIterator(this PancakeHouseMenu menu)
        {
            return new PancakeHouseMenuIterator(menu.GetMenuItems);
        }
    }
}
