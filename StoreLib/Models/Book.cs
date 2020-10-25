using System;

namespace StoreLib
{
    public class Book
    {
        int id {get;set;}
        string title {get;set;}
        string author {get;set;}
        double price {get;set;}
        string synopsis {get;set;}
        bookType type { get; set; }

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

    }
}
