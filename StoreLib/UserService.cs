using StoreDB.Models;
using StoreDB.Repos;
using System;

namespace StoreLib
{
    public class UserService
    {

        private IUserRepo repo;

        public UserService(IUserRepo repo) {
            this.repo = repo;
        }

        public void AddUser(User user) {
            repo.AddUser(user);
        }

        //  void UpdateUser(User user);
        //  User GetUserById(int id);
         public User GetUserByUsername(string username) {
             User user = new User();

             try {
                 user = repo.GetUserByUsername(username);
             }
             catch(InvalidOperationException) {
                 Console.WriteLine("You have entered an incorrect username or password.");
                 Console.WriteLine("Please verify your credentials and try again, or create an account");
             }

             return user;
         }
        //  List<User> GetAllUsers();
        //  void DeleteUser(User user);
        
             
        // public void SignIn(User user) {}
             
        
    }
}