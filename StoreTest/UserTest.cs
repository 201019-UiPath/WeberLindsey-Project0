using Xunit;
using StoreDB.Models;
using StoreDB;
using StoreDB.Repos;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace StoreTest
{
    public class UserTest
    {

        [Fact]
        public void AddUserShouldAdd(){
            // var options = new DbContextOptionsBuilder<StoreContext>().UseInMemoryDatabase("AddUserShouldAdd").Options;
            using var testContext = new StoreContext();
            IUserRepo repo = new DBRepo(testContext);
            User testUser = new User();
            
            //Arrange
            testUser.name = "Test Name";
            testUser.email = "testUser@email.com";
            testUser.username = "TestUser";
            testUser.password = "password";
            testUser.locationId = 1;

            //Act
            repo.AddUser(testUser);

            //Assert
            Assert.NotNull(testContext.Users.Single(u => u.name == testUser.name));

            repo.DeleteUser(testUser);
        }

        [Fact]
        public void GetUserByUsernameShouldGet() {
            using var testContext = new StoreContext();
            IUserRepo repo = new DBRepo(testContext);

            User testUser = new User();
            testUser.name = "Test Name";
            testUser.email = "testUser@email.com";
            testUser.username = "TestUser";
            testUser.password = "password";
            testUser.locationId = 1;
            repo.AddUser(testUser);            

            User result = repo.GetUserByUsername(testUser.username);

            Assert.NotNull(result);

            repo.DeleteUser(testUser);
        }

        [Fact]
        public void GetAllUsers() {
            using var testContext = new StoreContext();
            IUserRepo repo = new DBRepo(testContext);
            
            List<User> result = repo.GetAllUsers();

            Assert.NotNull(result);
        }

    }
}
