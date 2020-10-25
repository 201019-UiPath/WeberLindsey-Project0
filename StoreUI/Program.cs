using System;
using StoreUI.Menus;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling Welcome Menu
            IMenu startMenu = new WelcomeMenu();
            startMenu.Start();
        }
    }
}
