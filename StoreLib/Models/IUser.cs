using System;

namespace StoreLib
{
    public interface IUser
    {
        private string name;
        private string email;
        private string username;
        private string password;
        private Type userType;

         public void SignUp() {
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
             User newUser = new User(name, email, username, password);
             System.Console.WriteLine("User account created successfully!\n");

         }

         public void SignIn(string username, string password) {
             System.Console.WriteLine("Enter username: ");
             username = Console.ReadLine();

             System.Console.WriteLine("Enter password: ");
             password = Console.ReadLine();

             //TODO Create login validation
             //If validation successful, 
             
             //Direct to customer or manager menu depending on userType
             switch(userType) {
                 case User.Manager: 
                    IMenu startMenu = new ManagerMenu();
                    startMenu.Start();

                case User.Customer:
                    IMenu startMenu = new CustomerMenu();
                    startMenu.Start();
             }
                       

         }
    }
}