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
    public class ProductsMenu : IMenu
    {
        private string userInput;
        private Book selectedBook;
        private User signedInUser;
        private IUserRepo userRepo;
        private UserService userService;
        private IInventoryItemRepo inventoryItemRepo;
        private InventoryService inventoryService;
        private IBookRepo bookRepo;
        private BookService bookService;
        private ProductDetailsMenu productDetailsMenu;
        private StoreContext context;

        public ProductsMenu(User user, StoreContext context, IUserRepo userRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.signedInUser = user;
            this.context = context;
            this.userRepo = userRepo;
            this.bookRepo = bookRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.userService = new UserService(userRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);
        }
        public void Start() {

            do {

            Console.WriteLine("\nSelect a product: ");

            List<InventoryItem> items = GetProductsForUserLocation();
            foreach(InventoryItem item in items) {
                Book book = bookService.GetBookById(item.bookId);
                Console.WriteLine($" [{book.id}] {book.title} | {book.author} | {book.price} | Quantity: {item.quantity} ");
            }

            Console.WriteLine("[6] Back");

            userInput = Console.ReadLine();
            switch(userInput) {
                case "1":

                    selectedBook = bookService.GetBookById(1);
                    productDetailsMenu.Start();
                    break;

                case "2":
                    // selectedBook = bookService.GetBookById(2);
                    break;

                case "3":
                    // selectedBook = bookService.GetBookById(3);
                    break;

                case "4":
                    // selectedBook = bookService.GetBookById(4);
                    break;

                case "5":
                    // selectedBook = bookService.GetBookById(5);
                    break;

                case "6":
                    break;

                default:
                    //TODO create input validation for this InvalidInputMessage()
                    Console.WriteLine("Invalid product selected");
                    break;
                }

            this.productDetailsMenu = new ProductDetailsMenu(signedInUser, selectedBook, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
            } while(!userInput.Equals("6"));



        }
        





        public List<InventoryItem> GetProductsForUserLocation() {
            List<InventoryItem> items;
            int locationId = signedInUser.locationId;
            items = inventoryService.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }
    }
}