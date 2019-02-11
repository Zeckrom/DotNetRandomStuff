using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            //var cheapBooks = 
            //    from b in books
            //    where b.Price < 10
            //    orderby b.Title
            //    select b.Title;

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
