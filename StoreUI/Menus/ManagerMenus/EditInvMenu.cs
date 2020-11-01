using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus.ManagerMenus
{
    public class EditInvMenu : IMenu
    {
        private string userInput;
        private Book selectedBook;
        private User signedInUser;
        private StoreContext context;
        private ILocationRepo locationRepo;
        private LocationService locationService;
        private IInventoryItemRepo inventoryItemRepo;
        private InventoryService inventoryService;
        private IBookRepo bookRepo;
        private BookService bookService;
        private EditInvDetailsMenu editInvDetailsMenu;

        public EditInvMenu(User user, StoreContext context, ILocationRepo locationRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.signedInUser = user;
            this.context = context;
            this.locationRepo = locationRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.bookRepo = bookRepo;
            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);
        }

        public void Start() {

            do {
                Console.WriteLine("\nSelect location to manage: ");

                List<Location> locs = locationService.GetAllLocations();
                foreach(Location loc in locs) {
                    Console.WriteLine($" [{loc.id}] {loc.street1} {loc.street2} {loc.city} {loc.state} {loc.postalCode} ");
                }

                Console.WriteLine("[4] Back");

                userInput = Console.ReadLine();
                switch(userInput) {
                    case "1":
                        EditInventory(1);
                        break;

                    case "2":
                        EditInventory(2);
                        break;

                    case "3":
                        EditInventory(3);
                        break;

                    case "4":
                        break;

                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while(!userInput.Equals("4"));
        }


        /// <summary>
        /// Gets a list of all products at the manager's selected location
        /// </summary>
        /// <returns></returns>
        public List<InventoryItem> GetProductsForLocation(int locationId) {
            List<InventoryItem> items = inventoryService.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }


        public void EditInventory(int locationId) {
            string input;

            do {

                Console.WriteLine("Select an item to replenish: ");

                List<InventoryItem> items = GetProductsForLocation(locationId);
                foreach(InventoryItem item in items) {
                    Book book = bookService.GetBookById(item.bookId);
                    Console.WriteLine($" [{book.id}] {book.title} | {book.author} | {book.price} | Quantity: {item.quantity} ");
                }
                Console.WriteLine("[6] Back");

                input = Console.ReadLine();
                switch(input) {
                    case "1":
                        selectedBook =  bookService.GetBookById(1);
                        this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
                        editInvDetailsMenu.Start();
                        break;

                    case "2":
                        selectedBook =  bookService.GetBookById(2);
                        this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
                        editInvDetailsMenu.Start();
                        break;

                    case "3":
                        selectedBook =  bookService.GetBookById(3);
                        this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
                        editInvDetailsMenu.Start();
                        break;

                    case "4":
                        selectedBook =  bookService.GetBookById(4);
                        this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
                        editInvDetailsMenu.Start();
                        break;

                    case "5":
                        selectedBook =  bookService.GetBookById(5);
                        this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
                        editInvDetailsMenu.Start();
                        break;

                    case "6":
                        break;

                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }

            } while(!input.Equals("6"));

        }



    }
}