namespace StoreLib.Models
{
    public class Order
    {
        int id { get; set; }
        int userId { get; set; }
        string[] lineItem { get; set; }

        Order() {}

        Order(int id, int userId, string[] lineItem) {
            this.id = id;
            this.userId = userId;
            this.lineItem = lineItem;
        }
    }
}