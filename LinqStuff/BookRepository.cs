using System.Collections.Generic;

namespace LinqStuff
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Game of thrones", Price = 5},
                new Book() {Title = "Harry potter", Price = 9.99f},
                new Book() {Title = "Six of crows", Price = 12},
                new Book() {Title = "The hobbit", Price = 7},
                new Book() {Title = "Bird box", Price = 9}
            };
        }
    }
}