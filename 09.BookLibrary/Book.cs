namespace _09.BookLibrary
{
    using System;
    using System.Globalization;

    class Book
    {
        public string Name;
        public double Price;
        public string Author;
        public string ISBN;

        public DateTime releaseDAte;

        public Book(string name,string author, string date, string isbn, double price)
        {
            Name = name;
            Price = price;
            releaseDAte = DateTime.ParseExact(date, "d.MM.yyyy", CultureInfo.InvariantCulture);
            ISBN = isbn;
        }
    }
}
