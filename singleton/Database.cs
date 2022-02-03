using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction.singleton
{
    public class Database
    {
        public  static string host;

        private Database()
        {
        }

    public static void creatInstance(string hostName)
        {
            host = hostName;

        }


    }
}
