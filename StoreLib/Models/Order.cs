namespace StoreLib.Models
{
    public class Order
    {
        private int id { get; set; }
        private int userId { get; set; }
        private string[] lineItem { get; set; }

        Order() {}

        Order(int id, int userId, string[] lineItem) {
            this.id = id;
            this.userId = userId;
            this.lineItem = lineItem;
        }
    }
}