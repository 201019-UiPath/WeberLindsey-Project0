using System;

namespace StoreUI.Menus
{
    /// <summary>
    /// Welcome menu to be displayed on application launch
    /// </summary>
    public class WelcomeMenu : IMenu
    {
        public void Start() {
            string userInput;
            do{
                System.Console.WriteLine("Welcome to CF Books!");
                System.Console.WriteLine("Please select an option: ");

                //Menu Options
                System.Console.WriteLine("[0] Sign In \n[1] Sign Up \n[3] Exit");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0" :
                        System.Console.WriteLine("Sign In Selected");
                        break;
                    case "1":
                        System.Console.WriteLine("Sign Up Selected");
                        break;
                    case "3" :
                        System.Console.WriteLine("Exit");
                        Environment.Exit(0);
                        // Application.Exit();
                        break;
                }

            } while(!userInput.Equals("0") || !userInput.Equals("1") || !userInput.Equals("3"));
        }
    }
}