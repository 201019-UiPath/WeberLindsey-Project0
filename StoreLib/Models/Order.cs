namespace StoreLib.Models
{
    public class Order
    {
        int id { get; set; }
        string[] lineItem { get; set; }

        Order() {}

        Order(int id, string[] lineItem) {
            this.id = id;
            this.lineItem = lineItem;
        }
    }
}