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
                System.Console.WriteLine("Welcome to CF Books");

                //Menu Options
                System.Console.WriteLine("[0] Manage Inventory \n[1] Create Manager User");
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