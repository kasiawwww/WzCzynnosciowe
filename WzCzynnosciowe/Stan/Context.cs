using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Stan
{
    class Context
    {
        public Context(State state)
        {
            State = state;
            Change();
        }
        public State State { get; set; }

        public void Change()
        {
            State.Handle(this);
        }
    }
}
