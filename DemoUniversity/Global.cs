using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUniversity
{
    static public class Global
    {
        public static int maxStudents = 20;
        public static string CreateFullName(string first, string last)
        {
            return ($"{first} {last}");
        }

    }

    static public class Errors
    {
        public static string notEnoughSpace = "not enough space";
    }

}
