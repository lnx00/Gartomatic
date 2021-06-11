using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gartomatic
{
    static class Utils
    {
        private static int _currentID = 0;

        public static string EscapeString(string pString)
        {
            pString = pString.Replace("'", "\\'");
            pString = pString.Replace("\"", "\\\"");
            return pString;
        }

        public static int GetNextID()
        {
            _currentID++;
            return _currentID;
        }

    }
}
