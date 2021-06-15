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
            string bRoom = _browser.Address.Replace("https://gartic.io/", "");
            return (String.IsNullOrEmpty(bRoom)) ? "Unknown" : bRoom;
        }

        /* JS BRIDGE */
        public void Join()
        {
            _browser.ExecuteScriptAsync("GarticHook.ReJoin();");
        }

        public void Join(string pCode)
        {
            _browser.Load("https://gartic.io/" + pCode);
            _browser.ExecuteScriptAsyncWhenPageLoaded(MainWindow.GarticHook);
        }

        public void JoinQueue()
        {
            _browser.Load("https://gartic.io/");
            _browser.ExecuteScriptAsyncWhenPageLoaded(MainWindow.GarticHook);
        }

        public void Leave()
        {
            _browser.ExecuteScriptAsync("GarticHook.Leave();");
        }

        public void Report()
        {
            _browser.ExecuteScriptAsync("GarticHook.Report();");
        }

        public void Kick(string pUser)
        {
            _browser.ExecuteScriptAsync(String.Format("GarticHook.Kick('{0}');", Utils.EscapeString(pUser)));
        }

        public void Hint()
        {
            _browser.ExecuteScriptAsync("GarticHook.Hint();");
        }

        public void Skip()
        {
            _browser.ExecuteScriptAsync("GarticHook.Skip();");
        }

        public void SendChat(string pMessage)
        {
            _browser.ExecuteScriptAsync(String.Format("GarticHook.SendChat('{0}');", pMessage));
        }

        public void SendAnswer(string pAnswer)
        {
            _browser.ExecuteScriptAsync(String.Format("GarticHook.SendAnswer('{0}');", pAnswer));
        }

        public string GetAnswer()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetAnswer();");
            if (rs.Result.Success)
            {
                string result = rs.Result.Result.ToString();
                return result;
            }

            return null;
        }

        public string GetStatus()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetStatus();");
            if (rs.Result.Success)
            {
                string result = rs.Result.Result.ToString();
                return result;
            }

            return "Unknown";
        }

        public string GetName()
        {
            var rs = _browser.EvaluateScriptAsync("GarticHook.GetName();");
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

        public int GetID()
        {
            return _ID;
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
                string retVal = "[" + GetID() + "]\t" + GetRoom() + "\t"  + GetStatus() + "\t" + GetName();
                return retVal;
            } catch (Exception) { }

            return "[" + GetID() + "]\t" + GetRoom() + "\tError\tError";
        }

    }
}
