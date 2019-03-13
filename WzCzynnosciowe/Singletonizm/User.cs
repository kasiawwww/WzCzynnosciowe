using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.Singletonizm
{
    public class User
    {
        private static User instance;
        private User() { }
        public static User Instance
        {
            get
            {
                return instance != null ? instance : new User();
            }
        }
    }
}
