namespace StoreLib.Models
{
    public class Order
    {
        private int id { get; set; }
        private int userId { get; set; }
        private DateTime orderDate { get; set; }
        private double totalPrice { get; set; }
        private string[] lineItem { get; set; }

        Order() {}

        Order(int id, int userId, DateTime orderDate, double totalPrice, string[] lineItem) {
            this.id = id;
            this.userId = userId;
            this.orderDate = orderDate;
            this.totalPrice = totalPrice;
            this.lineItem = lineItem;
        }
    }
}