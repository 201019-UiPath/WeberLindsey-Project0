using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus.ManagerMenus
{
    /// <summary>
    /// The main menu for managers that were able to log in successfully
    /// </summary>
    public class ManagerMenu : IMenu
    {

        private string userInput;
        private User signedInUser;
        private IUserRepo userRepo;
        private UserService userService;
        private ILocationRepo locationRepo;
        private LocationService locationService;


        public ManagerMenu(User user, StoreContext context, IUserRepo userRepo, ILocationRepo locationRepo) {
            this.signedInUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);

            // this.productsMenu = new ProductsMenu(signedInUser, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
        }


        public void Start() {

            do{
                System.Console.WriteLine("\nWelcome to CF Books! What would you like to do today?");

                //Manager Menu Options
                System.Console.WriteLine("[1] Manage Inventory");
                System.Console.WriteLine("[2] Create Manager User");
                System.Console.WriteLine("[3] Exit");

                userInput = System.Console.ReadLine();
                switch (userInput)
                {
                    case "1" :
                        System.Console.WriteLine("Manage Inventory Selected");
                        break;
                    case "2":
                        User newUser = GetNewManagerDetails();
                        userService.AddUser(newUser);
                        break;
                    case "3":
                        System.Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while(!userInput.Equals("3"));
        }



        //TODO Add input validation to this for email/pw/username requirements
        /// <summary>
        /// Obtain user input to create new Manager User account
        /// </summary>
        /// <returns></returns>
        public User GetNewManagerDetails() {
            User user = new User();
            user.type = User.userType.Manager;
            string selectedLocation;

            Console.WriteLine("\nEnter name: ");
            user.name = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            user.email = Console.ReadLine();

            Console.WriteLine("Create a username: ");
            user.username = Console.ReadLine();

            Console.WriteLine("Create a password: ");
            user.password = Console.ReadLine();

            Console.WriteLine("Select preferred location: ");
            Boolean invalidSelection = true;
            do {
                List<Location> locs = locationService.GetAllLocations();
                foreach(Location loc in locs) {
                    Console.WriteLine($" {loc.id} {loc.city} {loc.state}");
                }

                selectedLocation = Console.ReadLine();
                switch(selectedLocation) {
                    case "1":
                        user.locationId = 1;
                        invalidSelection = false;
                        break;

                    case "2":
                        user.locationId = 2;
                        invalidSelection = false;
                        break;

                    case "3":
                        user.locationId = 3;
                        invalidSelection = false;
                        break;
                    
                    default:
                        //TODO change this to InvalidInputMessage()
                        Console.WriteLine("Invalid Selection\n");
                        break;
                } 
            } while (invalidSelection);

            Console.WriteLine("User account created!");
            return user;
        }




    }
}