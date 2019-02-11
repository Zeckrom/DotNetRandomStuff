using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManip
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Directory.CreateDirectory(@"d:\swag");

            var files = Directory.GetFiles(@"d:\Music", "*.*", SearchOption.AllDirectories);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
