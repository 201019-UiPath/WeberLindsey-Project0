using StoreUI.Menus;
using StoreDB;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Calls Welcome Menu
            StoreContext context = new StoreContext();
            IMenu welcomeMenu = new WelcomeMenu(new DBRepo(context), new DBRepo(context));
            welcomeMenu.Start();
        }
    }
}
