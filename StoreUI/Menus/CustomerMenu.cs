using System;

namespace StoreUI.Menus
{
    /// <summary>
    /// The main menu for customers that were able to log in successfully
    /// </summary>
    public class CustomerMenu : IMenu
    {
        public void Start() {
            string userInput;
            do{
                System.Console.WriteLine("Welcome to CF Books");

                //Menu Options
                System.Console.WriteLine("[0] View Products \n[1] View Order History \n[2] View Locations");
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