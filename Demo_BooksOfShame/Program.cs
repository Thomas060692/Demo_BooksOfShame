using Demo_BooksOfShame.BLL.Models;
using Demo_BooksOfShame.BLL.Services;

namespace Demo_BooksOfShame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo - Books of shame");

            BookService bookService = new BookService();

            IEnumerable<BookModel> books = bookService.GetAll();

            foreach (BookModel book in books)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
