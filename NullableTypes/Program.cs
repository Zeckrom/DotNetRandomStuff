using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault: " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            // Console.WriteLine("Value: " + date.Value);

            DateTime? date2 = new DateTime(2014, 1, 1);
            DateTime date3 = date2 ?? DateTime.Today;

            Console.WriteLine(date3);
        }
    }
}
