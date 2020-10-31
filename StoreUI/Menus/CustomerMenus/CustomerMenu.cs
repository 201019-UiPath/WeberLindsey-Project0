using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;
using StoreUI.Menus.CustomerMenus;
using StoreUI.Menus.ManagerMenus;

namespace StoreUI.Menus.CustomerMenus
{
    /// <summary>
    /// The main menu for customers that were able to log in successfully
    /// </summary>
    public class CustomerMenu : IMenu
    {
        private string userInput;
        private User signedInUser;
        private IUserRepo userRepo;
        private UserService userService;
        private ILocationRepo locationRepo;
        private LocationService locationService;
        private IInventoryItemRepo inventoryItemRepo;
        private InventoryService inventoryService;
        private IBookRepo bookRepo;
        private BookService bookService;
        private ProductsMenu productsMenu;


        public CustomerMenu(User user, StoreContext context, IUserRepo userRepo, ILocationRepo locationRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.signedInUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.bookRepo = bookRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);

            this.productsMenu = new ProductsMenu(signedInUser, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
        }

        public void Start() {

            do{
                Console.WriteLine("\nWelcome to CF Books! What would you like to do today?");

                //Customer Menu Options
                System.Console.WriteLine("[0] View Products");
                System.Console.WriteLine("[1] View Order History");
                System.Console.WriteLine("[2] Change Location");
                System.Console.WriteLine("[3] View Cart");
                System.Console.WriteLine("[4] Exit");
                userInput = System.Console.ReadLine();

                switch (userInput)
                {
                    case "0" :
                        productsMenu.Start();
                        System.Console.WriteLine("View Products Selected");                 
                        break;

                    case "1":
                        System.Console.WriteLine("View Order History Selected");
                        break;

                    case "2":
                        System.Console.WriteLine("Change Location Selected");
                        break;

                    case "3":
                        System.Console.WriteLine("View Cart Selected");
                        break;

                    case "4":
                        System.Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while(!userInput.Equals("4"));
        }


    }
}