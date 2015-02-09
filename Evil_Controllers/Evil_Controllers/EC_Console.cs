using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evil_Controllers
{
    class EC_Console
    {
        public static List<string> writeList = new List<string>();

        public static void WriteToConsole(string toWrite)
        {
            writeList.Add(toWrite);
        }
    }
}
