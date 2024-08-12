using Common;
using System.Collections;

namespace Four
{
    public class CafeMenu : IMenu
    {
        private Hashtable _menuItems;

        public CafeMenu()
        {
            _menuItems = new Hashtable();

            AddItem("Veggies burger and Fries", "Veggies burger in a bun with salad", true, 3.99);
            AddItem("Soup of the day", "Soup with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, and guacamole", true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);

            _menuItems.Add(menuItem.Name, menuItem);
        }

        public Hashtable GetMenuItems => _menuItems; // would not need this if I hadn't stuck with Common
    }
}
