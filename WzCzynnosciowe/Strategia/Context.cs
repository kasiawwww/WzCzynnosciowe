using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Strategia
{
    class Context
    {
        public Context(IPerson person)
        {
            Person = person;
        }
        public IPerson Person{ get; set; }

    }
}
