namespace StoreLib
{
    public class User
    {
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        string username { get; set; }
        string password { get; set; }
        string[] orders { get; set; }
        string[] cart { get; set; }

        enum Type {
            Customer,
            Manager,
        }

    }
}