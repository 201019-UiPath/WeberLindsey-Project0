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

        enum Type {
            Fiction,
            NonFiction,
        }

    }
}
