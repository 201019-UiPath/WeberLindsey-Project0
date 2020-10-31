using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;

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
        private ICartRepo cartRepo;
        private CartService cartService;
        private ICartItemRepo cartItemRepo;
        private CartItemService cartItemService;

        public ProductDetailsMenu(User user, Book book, StoreContext context, IUserRepo userRepo, IInventoryItemRepo inventoryItemRepo, IBookRepo bookRepo, ICartRepo cartRepo, ICartItemRepo cartItemRepo) {
            this.signedInUser = user;
            this.book = book;
            this.userRepo = userRepo;
            this.bookRepo = bookRepo;
            this.cartRepo = cartRepo;
            this.cartItemRepo = cartItemRepo;
            
            this.inventoryItemRepo = inventoryItemRepo;
            this.userService = new UserService(userRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.bookService = new BookService(bookRepo);
            this.cartService = new CartService(cartRepo);
            this.cartItemService = new CartItemService(cartItemRepo);
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
                Console.WriteLine($" {book.synopsis} \n");

                Console.WriteLine("[0] Add to cart");
                Console.WriteLine("[1] Back");

                userInput = Console.ReadLine();

                switch(userInput) {
                    case "0":
                        Console.WriteLine("How many would you like? ");
                        int quantity = Int32.Parse(Console.ReadLine());

                        Cart newCart = new Cart();
                        newCart.userId = signedInUser.id;
                        cartService.AddCart(newCart);

                        CartItem item = new CartItem();
                        Cart userCart = cartService.GetCartByUserId(signedInUser.id);
                        item.cartId = userCart.id;
                        item.bookId = book.id;
                        item.quantity = quantity;
                        cartItemService.AddCartItem(item);
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