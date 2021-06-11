using CefSharp;
using CefSharp.OffScreen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gartomatic
{
    class Bot
    {

        private ChromiumWebBrowser _browser;
        private int _ID;

        public Bot(ChromiumWebBrowser pBrowser)
        {
            _browser = pBrowser;
            _ID = Utils.GetNextID();
        }

        public string GetRoom()
        {
            return _browser.Address.Replace("https://gartic.io/", "");
        }

        /* JS BRIDGE */
        public void Join()
        {
            _browser.ExecuteScriptAsync("GarticHook.ReJoin()");
        }

        public void Join(string pCode)
        {
            _browser.Load("https://gartic.io/" + pCode);
            _browser.ExecuteScriptAsyncWhenPageLoaded(MainWindow.GarticHook);
        }

        public void Join(string pName = "", int pAvatar = 0)
        {
            _browser.ExecuteScriptAsync("GarticHook.Join(" + Utils.EscapeString(pName) + ", " + pAvatar + ")");
        }

        public void Leave()
        {
            _browser.ExecuteScriptAsync("GarticHook.Leave()");
        }

        public void Report()
        {
            _browser.ExecuteScriptAsync("GarticHook.Report()");
        }

        public void Kick(string pUser)
        {
            _browser.ExecuteScriptAsync("GarticHook.Kick(" + Utils.EscapeString(pUser) + ")");
        }

        public void Hint()
        {
            _browser.ExecuteScriptAsync("GarticHook.Hint()");
        }

        public void Skip()
        {
            _browser.ExecuteScriptAsync("GarticHook.Skip()");
        }

        public string GetAnswer()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetAnswer()");
            if (rs.Result.Success)
            {
                string result = rs.Result.Result.ToString();
                return result;
            }

            return null;
        }

        public string GetStatus()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetStatus()");
            if (rs.Result.Success)
            {
                string result = rs.Result.Result.ToString();
                return result;
            }

            return "Unknown";
        }

        public string GetName()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetName()");
            if (rs.Result.Success)
            {
                string result = rs.Result.Result.ToString();
                return result;
            }

            return "Unknown";
        }

        /* GETTER AND SETTER */
        public ChromiumWebBrowser GetBrowser()
        {
            return _browser;
        }

        public void SetBrowser(ChromiumWebBrowser pBrowser)
        {
            _browser = pBrowser;
        }

        /* OTHER */

        public void Destroy()
        {
            _browser.Dispose();
            _browser = null;
        }

        public override string ToString()
        {
            try
            {
                string retVal = "Room: " + GetRoom() + " | "  + GetStatus() + " | " + GetName();
                return retVal;
            } catch (Exception) { }
            return "Room: " + GetRoom();
        }

    }
}
