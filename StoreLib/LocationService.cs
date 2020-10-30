using StoreDB;
using StoreDB.Models;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreLib
{
    public class LocationService
    {
        private ILocationRepo repo;

        public LocationService(ILocationRepo repo) {
            this.repo = repo;
        }

        public void AddLocation(Location location) {
            repo.AddLocation(location);
        }

        // void UpdateLocation(Location location);
        //  Location GetLocationById(int id);
        //  Location GetLocationByState(string state);

        public List<Location> GetAllLocations() {
            List<Location> locations = repo.GetAllLocations();
            return locations;
        }

    }
}