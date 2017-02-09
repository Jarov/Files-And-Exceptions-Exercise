namespace _09.BookLibrary
{
    using System.Collections.Generic;

    class Library
    {
        public string Name;
        public List<Book> Books = new List<Book>();

        public Library(string name)
        {
            Name = name;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public double BooksPriceSum()
        {
            double sum = 0;
            foreach (Book book in Books)
                sum += book.Price;
            return sum;
        }
    }
}
