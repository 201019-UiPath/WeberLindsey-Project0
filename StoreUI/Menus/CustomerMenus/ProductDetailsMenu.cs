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
    public class ProductDetailsMenu : IMenu
    {
        private string userInput;
        private User signedInUser;
        private Book book;
        private IUserRepo userRepo;
        private UserService userService;
        private IInventoryItemRepo inventoryItemRepo;
        private InventoryService inventoryService;
        private IBookRepo bookRepo;
        private BookService bookService;

        public ProductDetailsMenu(User user, Book book, StoreContext context, IUserRepo userRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.signedInUser = user;
            this.book = book;
            this.userRepo = userRepo;
            this.bookRepo = bookRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.userService = new UserService(userRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);
        }

        /// <summary>
        /// Menu for customer to view detailed information of product 
        /// and add it to their cart for purchase or return to the previous menu
        /// </summary>
        public void Start() {

            do {
                Console.WriteLine("\nWhat would you like to do? ");

                //TODO add way to get the quantity from InventoryItemRepo Or not
                Console.WriteLine($" [{book.id}] {book.title} | {book.author} | {book.price} | Quantity:  ");
                Console.WriteLine($" {book.synopsis} ");

                Console.WriteLine("[0] Add to cart");
                Console.WriteLine("[1] Back");

                userInput = Console.ReadLine();

                switch(userInput) {
                    case "0":
                        Console.WriteLine("Add to cart selected");
                        break;

                    case "1":
                        break;

                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid Selection");
                        break;
                }
            } while(!userInput.Equals("1"));


        }
    }
}