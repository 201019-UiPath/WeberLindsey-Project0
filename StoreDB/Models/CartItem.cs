namespace StoreDB.Models
{
    public class CartItem
    {
        public int id { get; set; }
        public int userId { get; set; }
        public User user { get; set; }
        public int bookId { get; set; }
        public Book book { get; set; }

    }
}