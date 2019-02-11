using System.Collections.Generic;

namespace Lambda
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book("title 1", 5),
                new Book("title 2", 10),
                new Book("title 3", 666)
            };
        }
    }
}