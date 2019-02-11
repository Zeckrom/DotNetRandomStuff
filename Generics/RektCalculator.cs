using System;
using HelloWorld;

namespace Generics
{
    public class RektCalculator<TPerson> where TPerson : Person
    {
        public int CalculRekt(TPerson person)
        {
            switch (person.Origin)
            {
                case Origin.France:
                case Origin.Iceland:
                    Console.WriteLine("jawwek behi fraire");
                    return 0;
                case Origin.Tunisia:
                    Console.WriteLine("you're pretty much fucked");
                    return 36;
                case Origin.Libya:
                    Console.WriteLine("steal a plane or something and escape cuz you gona die");
                    return 9999;
                default:
                    return 666;
            }
        }
    }
}