using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Stan
{
    class SmallState : State
    {
        public override void Handle(Context context)
        {
            Console.SetWindowSize(70, Console.WindowHeight);
            context.State = new BigState();
        }

    }
}
