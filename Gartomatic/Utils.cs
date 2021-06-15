using CefSharp;
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

        public static Task SetProxy(this IWebBrowser webBrowser, string address)
        {
            return Cef.UIThreadTaskFactory.StartNew(() =>
            {
                var context = webBrowser.GetBrowser().GetHost().RequestContext;

                context.SetPreference("proxy", new Dictionary<string, object>
                {
                    ["mode"] = "fixed_servers",
                    ["server"] = address
                }, out _);
            });
        }

    }
}
