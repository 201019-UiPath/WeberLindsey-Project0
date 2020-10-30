using System;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus
{
    /// <summary>
    /// The main menu for customers that were able to log in successfully
    /// </summary>
    public class CustomerMenu : IMenu
    {
        private string userInput;
        private IUserRepo userRepo;
        private UserService userService;
        private ILocationRepo locationRepo;
        private LocationService locationService;
        private CustomerMenu customerMenu;
        private ManagerMenu managerMenu;

        public CustomerMenu(IUserRepo userRepo, ILocationRepo locationRepo) {
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);

            // this.customerMenu = new CustomerMenu(new DBRepo(context));
            // this.managerMenu = new ManagerMenu(new DBRepo(context));
        }

        public void Start() {
            string userInput;
            do{
                Console.WriteLine("Welcome to CF Books");

                //Customer Menu Options
                System.Console.WriteLine("[0] View Products");
                System.Console.WriteLine("[1] View Order History");
                System.Console.WriteLine("[2] Change Location");
                System.Console.WriteLine("[3] View Cart");
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