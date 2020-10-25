using System;
using System.Object;

namespace StoreUI.Menus
{
    /// <summary>
    /// The welcome menu for people who come in and stuff
    /// </summary>
    public class MainMenu : IMenu
    {
        public void Start() {
            string userInput;
            do{
                System.Console.WriteLine("Welcome to CF Books");

                //Menu Options
                System.Console.WriteLine("[0] Menu option \n[1] Another Menu Option");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0" :
                        System.Console.WriteLine("Menu option selected");
                        break;
                    case "1":
                        System.Console.WriteLine("Another menu option selected");
                        break;
                }

            } while(!userInput.Equals("0") || !userInput.Equals("1"));
        }
    }
}