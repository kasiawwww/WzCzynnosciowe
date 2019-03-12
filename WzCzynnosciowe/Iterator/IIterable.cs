using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Iterator
{
    interface IIterable
    {
        IIterator GetIterator();
    }
}
