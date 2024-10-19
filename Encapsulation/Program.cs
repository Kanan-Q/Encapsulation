namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(25, 2, 3, "ali ve Nino", "roman");
            book.ShowInfo();
            Library library = new Library();
            library.AddBook(book);
            library.ShowInfo();
            Book romanBook = library.GetFilteredBooks("ali ve Nino");
            if (romanBook != null)
            {
                romanBook.ShowInfo();
            }
            else
            {
                Console.WriteLine("bu janrda kitab yoxdu");
            }
        }
    }
}
