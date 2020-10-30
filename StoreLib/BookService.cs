using StoreDB.Repos;
using StoreDB;
using StoreDB.Models;

namespace StoreLib
{
    public class BookService
    {
        private IBookRepo repo;

        public BookService(IBookRepo repo) {
            this.repo = repo;
        }

        public void AddBook(Book book) {
            repo.AddBook(book);
        }

        //  void UpdateBook(Book book);
        //  Book GetBookById(int id);
        //  Book GetBookByTitle(string title);
        //  List<Book> GetAllBooks();
        //  void DeleteBook(Book book);

        
    }
}