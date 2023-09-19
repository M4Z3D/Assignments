using BookShop.Model;

namespace BookShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new Bookstore
            BookStore bookstore = new BookStore();

            // Create a new Book
            Books book1 = new Books
            {
                BookTitle = "Pigen de sendte tilbage",
                Author = "Donatella Di Pietrantonio",
                Price = 50.00M
            };

            // Add the new Book to the Bookstore's LinkedList<Book>
            bookstore.Books.AddLast(book1);

            // Create another book
            Books book2 = new Books
            {
                BookTitle = "Natrium Chlorid",
                Author = "Jussi Adler-Olsen",
                Price = 100.00M
            };

            // Add the second book to the Bookstore's LinkedList<Book>
            bookstore.Books.AddLast(book2);

            // Going through the amount of 'book' in 'bookstore' and printing it out
            foreach (var book in bookstore.Books) 
            {
                Console.WriteLine($"Title: {book.BookTitle}, Forfatter: {book.Author}, Pris: {book.Price} DKK");
            }
        }
    }
}