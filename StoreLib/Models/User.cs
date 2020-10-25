namespace StoreLib
{
    public class User
    {
        int id { get; set; }
        string name { get; set; }
        string email { get; set; }
        string username { get; set; }
        string password { get; set; }

        enum Type {
            Customer,
            Manager,
        }

    }
}