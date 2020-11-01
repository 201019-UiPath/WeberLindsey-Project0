using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;

namespace StoreUI.Menus.CustomerMenus
{
    public class EditCartMenu
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

        public EditCartMenu(User user, StoreContext context, IUserRepo userRepo, ILocationRepo locationRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.signedInUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.bookRepo = bookRepo;
            this.inventoryItemRepo = inventoryItemRepo;

            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);

            // this.productsMenu = new ProductsMenu(signedInUser, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));

        }


        public void Start() {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[] Back");


            userInput = Console.ReadLine();
            switch(userInput) {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                default:
                    //TODO create input validation for this InvalidInputMessage()
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
    }
}