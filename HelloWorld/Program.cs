using System;
using System.Collections.Generic;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var boy = new Person("Lotfi", Origin.Tunisia, "Male", 23);
            var girls = new List<Person>
            {
                new Person("Riba", Origin.Tunisia, "Female", 22),
                new Person("Croissant", Origin.France, "Female", 24),
                new Person("Saumon", Origin.Iceland, "Female", 23),
                new Person("Salah", Origin.Libya, "Female?", 21),
                new Person("Dream girl", Origin.DreamLand, "Female", 284651)
            };

            foreach (var girl in girls)
            {
                switch (girl.Origin)
                {
                    case Origin.France:
                    case Origin.Iceland:
                        boy.Migrate(girl.Origin);
                        break;
                    case Origin.Tunisia:
                        boy.Stanna();
                        break;
                    case Origin.Libya:
                        boy.TurningGayEmergency();
                        break;
                    default:
                        boy.JerkOut();
                        break;
                }
            }
        }
    }
}

