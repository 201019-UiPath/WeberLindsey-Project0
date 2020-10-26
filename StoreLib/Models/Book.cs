using System;
using System.Collections.Generic;

namespace StoreLib
{
    public class Book
    {
        private int id { get; set; }
        private string title { get; set; }
        private string author { get; set; }
        private double price { get; set; }
        private string synopsis { get; set; }
        private bookType type { get; set; }

        enum bookType {
            Fiction,
            NonFiction,
        }

        Book() {}

        Book(int id, string title, string author, double price, string synopsis, bookType type) {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
            this.synopsis = synopsis;
            this.type = type;
        }

        //Book GetBook() { } TODO
        //List<Book> GetAllBooks() { } TODO
        //List<Book> SearchBooks() { } TODO
        //void AddBookToInventory() { } TODO
        //void DeleteBookFromInventory() { } TODO

    }
}
