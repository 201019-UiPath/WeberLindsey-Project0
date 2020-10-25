namespace StoreLib
{
    public class User
    {
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        string username { get; set; }
        string password { get; set; } // Not the password that youre looking for. Move along.
        string[] orders { get; set; }
        string[] cart { get; set; }
        userType type { get; set; }

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