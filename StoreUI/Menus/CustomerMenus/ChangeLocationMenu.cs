using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus.CustomerMenus
{
    public class ChangeLocationMenu
    {
        private string userInput;
        private User signedInUser;
        private IUserRepo userRepo;
        private UserService userService;
        private ILocationRepo locationRepo;
        private LocationService locationService;
 
        public ChangeLocationMenu(User user, StoreContext context, IUserRepo userRepo, ILocationRepo locationRepo) {
            this.signedInUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;

            this.userService = new UserService(userRepo);
            this.locationService = new LocationService(locationRepo);
        }

        /// <summary>
        /// Displays all locations 
        /// and allows options for user to change their preferred shopping location
        /// </summary>
        public void Start() {

            do{

                Console.WriteLine("\nSelect your preferred location: ");

                /// <summary>
                /// Displays all locations for user to select from
                /// </summary>
                /// <returns></returns>
                List<Location> locations = locationService.GetAllLocations();
                foreach(Location location in locations) {
                    Console.WriteLine($" [{location.id}] {location.street1} {location.street2} {location.city} {location.state} {location.postalCode} ");
                }
                Console.WriteLine("[4] Back");

                userInput = Console.ReadLine();
                switch(userInput) {
                    case "1":
                        UpdateUserLocation(1);
                        break;
                    case "2":
                        UpdateUserLocation(2);
                        break;
                    case "3":
                        UpdateUserLocation(3);
                        break;
                    case "4":
                        break;
                    default:
                        //TODO create input validation for this InvalidInputMessage()
                        Console.WriteLine("Invalid selection");
                        break;
                }
            } while(!userInput.Equals("4"));

        }

        /// <summary>
        /// Update's preferred location for user
        /// and saves location selection
        /// </summary>
        public void UpdateUserLocation(int id) {
            signedInUser.locationId = id;
            userService.UpdateUser(signedInUser);

            Console.WriteLine("Location updated!\n");
        }

    }
}