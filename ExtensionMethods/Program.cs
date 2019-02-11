using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "this is supposed to be a very long post post post post post post post post....";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }
    }
}
