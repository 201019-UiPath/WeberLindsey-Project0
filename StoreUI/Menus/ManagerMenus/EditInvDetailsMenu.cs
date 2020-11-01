using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus.ManagerMenus
{
    public class EditInvDetailsMenu
    {
        private string userInput;
        private Book book;
        private User signedInUser;
        private ILocationRepo locationRepo;
        private LocationService locationService;
        IInventoryItemRepo inventoryItemRepo;
        InventoryService inventoryService;
        IBookRepo bookRepo;
        BookService bookService;

        public EditInvDetailsMenu(User user, Book book, StoreContext context, ILocationRepo locationRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo) {
            this.book = book;
            this.signedInUser = user;
            this.locationRepo = locationRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.bookRepo = bookRepo;

            this.locationService = new LocationService(locationRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);

            // this.editInvDetailsMenu = new EditInvDetailsMenu(signedInUser, context, new DBRepo(context),new DBRepo(context), new DBRepo(context));
        }

        public void Start() {
            Console.WriteLine("This is the Edit Inventory Details Menu!");
        }








    }
}