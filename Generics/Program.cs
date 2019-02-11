using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person("yahia", Origin.Tunisia, "M", 23);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var persons = new GenericList<Person>();
            //persons.Add(person);

            //var dicitionary = new GenericDictionary<string, Person>();
            //dicitionary.Add("123", new Person());

            var number = new Nullable<int>();
            Console.WriteLine("has value ?" + number.HasValue);
            Console.WriteLine("value: " + number.GetValueOrDefault());
        }
    }
}
