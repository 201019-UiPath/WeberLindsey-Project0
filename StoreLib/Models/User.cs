using System;

namespace StoreLib
{
    public class User
    {
        //TODO include defaultLocation property? or have customers select it upon login?
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string username { get; set; }
        private string password { get; set; } 
        private string[] orders { get; set; }

        //Also when getting AllCustomers etc assign that data to Lists?
        //possibly use Bag collection for cart
        //https://docs.microsoft.com/en-us/dotnet/api/system.collections.concurrent.concurrentbag-1?view=netcore-3.1
        private string[] cart { get; set; }
        private userType type { get; set; }

        enum userType {
            Customer,
            Manager,
        }

        User() {}

        User(string name, string email, string username, string password, userType type) {
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
            this.type = type;
        }

        User(string name, string email, string username, string password, string[] orders, string[] cart, userType type) {
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
            this.orders = orders;
            this.cart = cart;
            this.type = type;
        }

        User(int id, string name, string email, string username, string password, userType type) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
            this.type = type;
        }

        User(int id, string name, string email, string username, string password, string[] orders, string[] cart, userType type) {
            this.id = id;
            this.name = name;
            this.email = email;
            this.username = username;
            this.password = password;
            this.orders = orders;
            this.cart = cart;
            this.type = type;
        }

        public void SignIn(string username, string password) {
            System.Console.WriteLine("Enter username: ");
            username = Console.ReadLine();

            System.Console.WriteLine("Enter password: ");
            password = Console.ReadLine();

            //TODO Create login validation
            //If validation successful, 
             
            //Direct to customer or manager menu depending on userType TODO relocate this to menu and instead have this method return a boolean
            switch(userType) {
                case Manager: 
                    IMenu startMenu = new ManagerMenu();
                    startMenu.Start();

                case Customer:
                    IMenu startMenu = new CustomerMenu();
                    startMenu.Start();
             }}
             
        public void SignUp(string name, string email, string username, string password, Type userType) {
            System.Console.WriteLine("Please provide your first and last name: ");
            name = Console.ReadLine();

            System.Console.WriteLine("Please provide your email address: ");
            email = Console.ReadLine();

            System.Console.WriteLine("Choose a username: ");
            username = Console.ReadLine();

            System.Console.WriteLine("Create a password: ");
            password = Console.ReadLine();

            //TODO create validation for username and email addresses
            //If validation passes,
            //Edit this to include the userType
            User newUser = new User(name, email, username, password, User.userType.Customer);
            System.Console.WriteLine("User account created successfully!\n");
        }

        public void CreateManager() {}
        public void DeleteManager() {}

    }
}