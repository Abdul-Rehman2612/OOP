using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Utils
{
    public class Utility
    {
        private static string ConnectionString = "";

        public static string GetConnectionString()
        {
            return ConnectionString;
        }
    }
}
