using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WzCzynnosciowe.HardCode
{
    public class HardCodeClass
    {
        int roleId;
        string userName;
        public HardCodeClass(int roleId, string userName)
        {
            this.roleId = roleId;
            this.userName = userName;
        }
        public string Info()
        {
            if (roleId == int.Parse((ConfigurationManager.AppSettings["user"])))
            {
                if (userName == ConfigurationManager.AppSettings["user"])
                {
                    return File.ReadAllText(ConfigurationManager.AppSettings["path"]);
                }
            }
            return "";
        }
    }
}
