namespace StoreUI.Menus.ManagerMenus
{
    /// <summary>
    /// The main menu for managers that were able to log in successfully
    /// </summary>
    public class ManagerMenu : IMenu
    {
        public void Start() {
            string userInput;
            do{
                System.Console.WriteLine("\nWelcome to CF Books! What would you like to do today?");

                //Menu Options
                System.Console.WriteLine("[0] Manage Inventory \n[1] Create Manager User");
                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "0" :
                        System.Console.WriteLine("Manage Inventory Selected");
                        break;
                    case "1":
                        System.Console.WriteLine("Another menu option selected");
                        break;
                }

            } while(!userInput.Equals("0") || !userInput.Equals("1"));
        }






    }
}