using Common;

namespace Two
{
    public class DinerMenuIterator(MenuItem[] items, int position = 0) : IIterator
    {
        public bool HasNext => position < items.Length && items[position] != null;

        public object Next
        {
            get
            {
                var menuItem = items[position];
                position++;
                return menuItem;
            }
        }
    }
}
