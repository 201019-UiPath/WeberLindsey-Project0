using System.Collections.Generic;
using StoreDB.Models;
using System.Linq;
using StoreDB.Repos;

namespace StoreDB
{
    public class DBRepo : IBookRepo, ILocationRepo, IUserRepo, IInventoryItemRepo, ICartItemRepo, ILineItemRepo, IOrderRepo
    {
        private StoreContext context;

        public DBRepo(StoreContext context) {
            this.context = context;
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete Book data
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book) {
            context.Books.Add(book);
            context.SaveChanges();
        }
        public void UpdateBook(Book book) {
            context.Books.Update(book);
            context.SaveChanges();
        }
        public Book GetBookById(int id) {
            return (Book) context.Books.Where(x => x.id == id);
        }
        public Book GetBookByTitle(string title) {
            return (Book) context.Books.Where(x => x.title == title);
        }
        public List<Book> GetAllBooks() {
            // return context.SuperVillains.Select(x=>x).Include("SuperPowers").ToList();
            return context.Books.Select(x => x).ToList();
        }
        public void DeleteBook(Book book) {
            context.Books.Remove(book);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete Location data
        /// </summary>
        /// <param name="location"></param>
        public void AddLocation(Location location) {
            context.Locations.Add(location);
            context.SaveChanges();
        }
        public void UpdateLocation(Location location) {
            context.Locations.Update(location);
            context.SaveChanges();
        }
        public Location GetLocationById(int id) {
            return (Location) context.Locations.Where(x => x.id == id);
        }
        public Location GetLocationByState(string state) {
            return (Location) context.Locations.Where(x => x.state == state);
        }
        public List<Location> GetAllLocations() {
            return context.Locations.Select(x => x).ToList();
        }
        public void DeleteLocation(Location location) {
            context.Locations.Remove(location);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete User data
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user) {
            context.Users.Add(user);
            context.SaveChanges();
        }
        public void UpdateUser(User user) {
            context.Users.Update(user);
            context.SaveChanges();
        }
        public User GetUserById(int id) {
            return (User) context.Users.Where(x => x.id == id);
        }
        public User GetUserByUsername(string username) {
            return (User) context.Users.Single(x => x.username == username);
        }
        public List<User> GetAllUsers() {
            return context.Users.Select(x => x).ToList();
        }
        public void DeleteUser(User user) {
            context.Users.Remove(user);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete Inventory data
        /// </summary>
        /// <param name="inventory"></param>
        public void AddInventoryItem(InventoryItem inventory) {
            context.InventoryItems.Add(inventory);
            context.SaveChanges();
        }
        public void UpdateInventoryItem(InventoryItem inventoryItem) {
            context.InventoryItems.Update(inventoryItem);
            context.SaveChanges();
        }
        public InventoryItem GetInventoryItemById(int id) {
            return (InventoryItem) context.InventoryItems.Where(x => x.id == id);
        }
        public List<InventoryItem> GetAllInventoryItemsById(int id) {
            return context.InventoryItems.Where(x => x.id == id).ToList();
        }
        public InventoryItem GetInventoryItemByLocationId(int id) {
            return (InventoryItem) context.InventoryItems.Where(x => x.locationId == id);
        }
        public List<InventoryItem> GetAllInventoryItemsByLocationId(int id) {
            return context.InventoryItems.Select(x => x).Where(x => x.locationId == id).ToList();
        }
        public void DeleteInventoryItem(InventoryItem inventory) {
            context.InventoryItems.Remove(inventory);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete Cart data
        /// </summary>
        /// <param name="cart"></param>
        public void AddCartItem(CartItem cart) {
            context.CartItems.Add(cart);
            context.SaveChanges();
        }
        public void UpdateCartItem(CartItem cartItem) {
            context.CartItems.Update(cartItem);
            context.SaveChanges();
        }
        public CartItem GetCartItemById(int id) {
            return (CartItem) context.CartItems.Where(x => x.id == id);
        }
        public CartItem GetCartItemByUserId(int id) {
            return (CartItem) context.CartItems.Where(x => x.userId == id);
        }
        public List<CartItem> GetAllCartItemsByUserId(int id) {
            return context.CartItems.Where(x => x.userId == id).ToList();
        }
        public void DeleteCartItem(CartItem cart) {
            context.CartItems.Remove(cart);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete LineItem data
        /// </summary>
        /// <param name="lineItem"></param>
        public void AddLineItem(LineItem lineItem) {
            context.LineItems.Add(lineItem);
            context.SaveChanges();
        }
        public void UpdateLineItem(LineItem lineItem) {
            context.LineItems.Update(lineItem);
            context.SaveChanges();
        }
        public LineItem GetLineItemByOrderId(int id) {
            return (LineItem) context.LineItems.Where(x => x.orderId == id);
        }
        public List<LineItem> GetAllLineItemsByOrderId(int id) {
            return context.LineItems.Where(x => x.orderId == id).ToList();;
        }
        public void DeleteLineItem(LineItem lineItem) {
            context.LineItems.Remove(lineItem);
            context.SaveChanges();
        }


        /// <summary>
        /// Methods to Add, Update, Get and Delete Order data
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order) {
            context.Orders.Add(order);
            context.SaveChanges();
        }
        public void UpdateOrder(Order order) {
            context.Orders.Update(order);
            context.SaveChanges();
        }
        public Order GetOrderById(int id) {
            return (Order) context.Orders.Where(x => x.id == id);
        }
        public Order GetOrderByUserId(int id) {
            return (Order) context.Orders.Where(x => x.userId == id);
        }
        public Order GetOrderByLocationId(int id) {
            return (Order) context.Orders.Where(x => x.locationId == id);
        }
        public List<Order> GetAllOrdersByLocationId(int id) {
            return context.Orders.Where(x => x.locationId == id).ToList();
        }
        public List<Order> GetAllOrdersByUserId(int id) {
            return context.Orders.Where(x => x.userId == id).ToList();
        }
        public void DeleteOrder(Order order) {
            context.Orders.Remove(order);
            context.SaveChanges();
        }

    }
}
