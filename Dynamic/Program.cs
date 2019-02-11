using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            var reflectionBitch = typeof(Person).GetField("_name", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            Console.WriteLine(reflectionBitch);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
        }
    }
}
