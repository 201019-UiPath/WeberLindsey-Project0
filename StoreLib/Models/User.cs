namespace StoreLib
{
    public class User
    {
        private int id { get; set; }
        private string name { get; set; }
        private string email { get; set; }
        private string username { get; set; }
        private string password { get; set; } // Not the password that youre looking for. Move along.
        private string[] orders { get; set; }
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