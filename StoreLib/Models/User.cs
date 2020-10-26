namespace StoreLib
{
    public class User
    {
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

    }
}