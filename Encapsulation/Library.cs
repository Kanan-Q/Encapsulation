
namespace Encapsulation
{
    internal class Library
    {
        private Book[] Books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }
        public Book GetFilteredBooks(string Genre)
        {
            Book FoundBook = null;
            foreach (var item in Books)
            {
                if (item.genre == Genre)
                {
                    FoundBook = item;
                    return FoundBook;
                }
            }
            return FoundBook;
        }
        public Book[] GetFilteredBooks(double minPrice, double maxPrice)
        {
            Book[] filteredBooks = new Book[0];
            foreach (var item in Books)
            {
                if (item.price >= minPrice && item.price <= maxPrice)
                {
                    Array.Resize(ref filteredBooks, filteredBooks.Length + 1);
                    filteredBooks[filteredBooks.Length - 1] = item;
                }
            }
            return filteredBooks;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Kitablar:{Books}");
        }
    }
}

