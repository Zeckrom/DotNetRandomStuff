using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));

            const int factor = 5;

            Func<int, int> multiplier = n => n * factor;

            Console.WriteLine(multiplier(10));

            Console.WriteLine("________________________________________________________");

            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 12);

            foreach (var cheapBook in cheapBooks)
            {
                Console.WriteLine(cheapBook.Title);
            }
        }

/*
        static int Square(int number)
        {
            return number * number;
        }
*/
    }
}
