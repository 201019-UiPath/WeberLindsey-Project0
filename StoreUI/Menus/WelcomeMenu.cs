using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;
using StoreUI.Menus.CustomerMenus;
using StoreUI.Menus.ManagerMenus;

namespace StoreUI.Menus
{
    /// <summary>
    /// Welcome menu to be displayed on application launch
    /// </summary>
    public class WelcomeMenu : IMenu
    {
        private string userInput;
        private User signedInUser;
        private StoreContext context;
        private IUserRepo userRepo;
        private UserService userService;
        private ILocationRepo locationRepo;
        private LocationService locationService;
        private ICartRepo cartRepo;
        private CartService cartService;
        private CustomerMenu customerMenu;
        private ManagerMenu managerMenu;

        public WelcomeMenu(StoreContext context,IUserRepo userRepo, ILocationRepo locationRepo, ICartRepo cartRepo) {
            this.context = context;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.cartRepo = cartRepo;

            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);
            this.cartService = new CartService(cartRepo);
        }


        public void Start() {

            do{               
                System.Console.WriteLine("\nWelcome to CF Books! Please select an option: ");

                //Welcome Menu options
                Console.WriteLine("[1] Sign In");
                Console.WriteLine("[2] Sign Up");
                Console.WriteLine("[3] Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1" :
                        User user = SignIn();
                        break;

                    case "2":
                        User newUser = GetNewUserDetails();
                        userService.AddUser(newUser);
                        break;

                    case "3" :
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while(!userInput.Equals("3"));
        }


        /// <summary>
        /// Obtain user input to sign in as existing user and redirect to appropriate menu
        /// </summary>
        /// <returns></returns>
        public User SignIn() {
            string username;
            string password;
            User user = new User();

            Console.WriteLine("\nEnter username: ");
            username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            try {
                user = userService.GetUserByUsername(username);
                if(user.password != password) {
                throw new System.ArgumentException();         
                } else {
                    signedInUser = user;
                    if(user.type == User.userType.Manager) {
                        managerMenu = new ManagerMenu(signedInUser, context, new DBRepo(context), new DBRepo(context));
                        managerMenu.Start();
                    }

                    if(user.type == User.userType.Customer) {
                        customerMenu = new CustomerMenu(signedInUser, context);

                        //Deletes existing cart
                        try{
                            cartService.DeleteCart(cartService.GetCartByUserId(signedInUser.id));
                        } catch(InvalidOperationException) {} 
                        finally {
                            //Creates new cart for customer user
                            Cart newCart = new Cart();
                            newCart.userId = signedInUser.id;
                            cartService.AddCart(newCart);

                            customerMenu.Start();
                        }

                        
                    }
                }
            } catch(ArgumentException) {
                //TODO change this to validation function
                    Console.WriteLine("\nYou have entered an invalid password");
            } catch(InvalidOperationException) {
                //TODO change this to validation function and create custom exception
                    Console.WriteLine("\nYou have entered an invalid username");
            }

            return user;
        }


        //TODO Add input validation to this for email/pw/username requirements
        /// <summary>
        /// Obtain user input to create new User account
        /// </summary>
        /// <returns></returns>
        public User GetNewUserDetails() {
            User user = new User();
            user.type = User.userType.Customer;
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
                    Console.WriteLine($" [{loc.id}] {loc.city} {loc.state}");
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

            Console.WriteLine("Account created!");
            return user;
        }

    }
}
