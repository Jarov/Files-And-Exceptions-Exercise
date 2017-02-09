using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _09.BookLibrary
{
    class BookLibrary
    {
        static void Main()
        {
            string[] inPut = File.ReadAllLines(@"..\..\inPut.txt");
            int BooksCount = int.Parse(inPut.First());

            List<Library> publishers = new List<Library>();

            for (int currentBook = 1; currentBook < inPut.Count(); currentBook++)
            {
                string[] BookInfo = inPut[currentBook].Split(' ');

                publishers.Add(new Library(BookInfo[2]));

                publishers[currentBook - 1].AddBook(new Book(
                    BookInfo[0],
                    BookInfo[1],
                    BookInfo[3],
                    BookInfo[4],
                    double.Parse(BookInfo[5])));
            }
        }
    }
}
