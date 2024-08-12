using System.Collections;

namespace Common
{
    public class PancakeHouseMenu : IMenu
    {
        private ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("Special pancake breakfast", "Pancakes with scrambled eggs and toast", true, 2.99);
            AddItem("Regular pancake breakfast", "Pancakes with fried eggs and sausage", false, 2.99);
            AddItem("Blueberry pancakes", "Pancakes with fresh blueberries", true, 3.49);
            AddItem("Waffels", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);

            _menuItems.Add(menuItem);
        }

        public ArrayList GetMenuItems => _menuItems;
    }
}
