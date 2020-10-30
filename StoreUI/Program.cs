using StoreUI.Menus;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //REMOVE THIS - temp data to test functionality
            // Book book1 = new Book();
            // book1.title = "Dirk Gently's Holistic Detective Agency";
            // book1.author= "Douglas Adams";
            // book1.price = 15.99;
            // book1.synopsis = "temp synopsis.";
            // book1.type =Book.bookType.Fiction;

            // Book book2 = new Book(2, "Origin", "Dan Brown", 26.95, "temp synopsis", Book.bookType.Fiction);
            // Book book3 = new Book(3, "The Martian", "Andy Weir", 15.50, "temp synopsis", Book.bookType.Fiction);
            // Book book4 = new Book(4, "Genki: Elementary Japanese I", "Banno Eri", 90.00, "Learn Japanese", Book.bookType.NonFiction);
            // Book book5 = new Book(5, "World War Z", "Max Brooks", 15.50, "temp synopsis", Book.bookType.Fiction);
            // book1.AddBook();
            // book2.AddBook();
            // book3.AddBook();
            // book4.AddBook();
            // book5.AddBook();

            // Location location1 = new Location(1, "314 Elm Street", "", "Springwood", "OH", "12345");
            // Location location2 = new Location(2, "123 Sesame Street", "", "Nowhere", "FL", "54321");
            // Location location3 = new Location(3, "1625 Nota Street", "Tampa", "FL", "34689");
            // location1.AddLocation();
            // location2.AddLocation();
            // location3.AddLocation();

            // Inventory inventory1 = new Inventory(1, 1, 1, 10);
            // Inventory inventory2 = new Inventory(2, 1, 2, 5);
            // Inventory inventory3 = new Inventory(3, 1, 3, 10);
            // Inventory inventory4 = new Inventory(4, 1, 4, 12);
            // Inventory inventory5 = new Inventory(5, 1, 5, 13);
            // Inventory inventory6 = new Inventory(6, 2, 1, 10);
            // Inventory inventory7 = new Inventory(7, 2, 2, 17);
            // Inventory inventory8 = new Inventory(8, 2, 3, 5);
            // Inventory inventory9 = new Inventory(9, 2, 4, 0);
            // Inventory inventory10 = new Inventory(10, 2, 5, 7);
            // Inventory inventory11 = new Inventory(11, 3, 1, 10);
            // Inventory inventory12 = new Inventory(12, 3, 2, 16);
            // Inventory inventory13 = new Inventory(13, 3, 3, 8);
            // Inventory inventory14 = new Inventory(14, 3, 4, 2);
            // Inventory inventory15 = new Inventory(15, 3, 5, 11);
            // inventory1.AddInventoryItem();
            // inventory2.AddInventoryItem();
            // inventory3.AddInventoryItem();
            // inventory4.AddInventoryItem();
            // inventory5.AddInventoryItem();
            // inventory6.AddInventoryItem();
            // inventory7.AddInventoryItem();
            // inventory8.AddInventoryItem();
            // inventory9.AddInventoryItem();
            // inventory10.AddInventoryItem();
            // inventory11.AddInventoryItem();
            // inventory12.AddInventoryItem();
            // inventory13.AddInventoryItem();
            // inventory14.AddInventoryItem();
            // inventory15.AddInventoryItem();

            // User user1 = new User(1, 1, "Wade Wilson", "mrpool@gmail.ca", "Deadpool", "deadpool", User.userType.Customer);
            // User user2 = new User(2, 2, "Glados", "forscience@aperture.com", "Glados", "aperture", User.userType.Customer);
            // User user3 = new User(3, 3, "Lindsey Weber", "notmyemail@gmail.com", "Lindsey", "test", User.userType.Manager);
            // user1.AddUser();
            // user2.AddUser();
            // user3.AddUser();

            // Order order1 = new Order(1, 1, 1, 42.94, "10/28/2020  7:08:00");
            // Order order2 = new Order(2, 2, 3, 15.50, "10/31/2020  11:50:00");
            // Order order3 = new Order(3, 1, 2, 465.50, "10/28/2020  5:22:00");
            // Order order4 = new Order(4, 2, 1, 15.99, "10/30/2020  3:33:33");
            // order1.AddOrder();
            // order2.AddOrder();
            // order3.AddOrder();
            // order4.AddOrder();


            // LineItem lineItem1 = new LineItem(1, 1, 1, 15.99, 1);
            // LineItem lineItem2 = new LineItem(2, 1, 2, 26.95, 1);
            // LineItem lineItem3 = new LineItem(3, 2, 3, 15.50, 1);
            // LineItem lineItem4 = new LineItem(4, 3, 4, 90.00, 5);
            // LineItem lineItem5 = new LineItem(5, 3, 5, 15.50, 1);
            // LineItem lineItem6 = new LineItem(6, 4, 1, 15.99, 1);
            // lineItem1.AddLineItem();
            // lineItem2.AddLineItem();
            // lineItem3.AddLineItem();
            // lineItem4.AddLineItem();
            // lineItem5.AddLineItem();
            // lineItem6.AddLineItem();

            // Cart cart1 = new Cart(1, 1, 3);
            // Cart cart2 = new Cart(2, 1, 5);
            // cart1.AddCartItem();
            // cart2.AddCartItem();



            //Calls Welcome Menu
            IMenu startMenu = new WelcomeMenu();
            startMenu.Start();
        }
    }
}
