using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Strategia
{
    class Lumberman : IPerson
    {
        public string[] Data()
        {
            return new string[] { "Normal kick", "Punch with ax" };
        }
    }
}
