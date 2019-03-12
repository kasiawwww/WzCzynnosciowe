using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Strategia
{
    class StrongKickPerson : IPerson
    {
        public string[] Data()
        {
            return new string[] { "Strong kick", "Normal punch" };

        }
    }
}
