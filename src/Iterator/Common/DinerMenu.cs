namespace Common
{
    public class DinerMenu : IMenu
    {
        private static int MaxItems = 6;
        private int _numberOfItems = 0;
        private MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MaxItems];

            AddItem("Veg BLT", "Fake bacon with lettuce and tomato", true, 2.99);
            AddItem("BLT", "Bacon with lettuce and tomato", false, 2.99);
            AddItem("Soup of the day", "Soup, with a side of garlic bread", false, 3.29);
            AddItem("Hot Dog", "Sausage in a roll", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);

            if (_numberOfItems >= MaxItems)
                Console.WriteLine("Sorry, menu is full.");
            else
            {
                _menuItems[_numberOfItems] = menuItem;

                _numberOfItems++;
            }
        }

        public MenuItem[] GetMenuItems => _menuItems;
    }
}
