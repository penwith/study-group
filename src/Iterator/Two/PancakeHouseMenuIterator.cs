using Common;
using System.Collections;

namespace Two
{
    public class PancakeHouseMenuIterator(ArrayList items, int position = 0) : IIterator
    {
        public bool HasNext => position < items.Count;

        public object Next
        {
            get
            {
                var menuItem = items[position] as MenuItem;
                position++;
                return menuItem;
            }
        }
    }
}
