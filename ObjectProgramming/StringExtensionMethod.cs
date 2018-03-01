using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ObjectProgramming
{
    public static class StringExtensionMethod
    {
        public static string MyToString(this string value)
        {
            return value + "1";
        }

        public static string MyAClass(this AClass a)
        {
            return a.Y + "sdfdsf";
        }
    }
}
