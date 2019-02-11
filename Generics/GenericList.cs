using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T item)
        {

        }

        public T this[int index] => throw new NotImplementedException();
    }
}
