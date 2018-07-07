namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibraryModification
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Book> books = new List<Book>();
            for (int i = 0; i < n; i++)
            {
                String[] input = Console.ReadLine().Split(' ').ToArray();

                Book book = new Book
                {

                    Title = input[0],
                    Autor = input[1],
                    Publisher = input[2],

                    ReleaseDate = DateTime.ParseExact(input[3],
                    "dd.MM.yyyy", CultureInfo.InvariantCulture),

                    IsbnNumber = int.Parse(input[4]),


                };

                book.Price = double.Parse(input[5]);

                books.Add(book);
            }

            Library library = new
            {
                Name = "NASO",
                books = books,
            };

            DateTime date = DateTime.ParseExact(Console.ReadLine()
               , "dd.MM.yyyy", CultureInfo.InvariantCulture);


            List<Book> sortedBooks = new List<Book>();

            foreach (var book in books)
            {
                if (book.ReleaseDate > date)
                {
                    sortedBooks.Add(book);
                }
            }

            foreach (var book in sortedBooks
                .OrderBy(b => b.ReleaseDate)
                .ThenBy(b => b.Autor))
            {
                Console.WriteLine("{0} -> {1:f2}", book.Title, book.ReleaseDate.ToString("dd.MM.yyyy"));
            }

        }
    }
}
