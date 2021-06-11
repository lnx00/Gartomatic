using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.OffScreen;

namespace Gartomatic
{
    public partial class MainWindow : Form
    {
        private BindingList<Bot> _bots;
        private CefSettings _cefSettings;

        public static string GarticHook;

        public MainWindow()
        {
            InitializeComponent();
            Cef.EnableWaitForBrowsersToClose();

            // Init Client List
            _bots = new BindingList<Bot>();
            listClients.DataSource = _bots;

            // Init Browser Settings
            _cefSettings = new CefSettings();
            _cefSettings.WindowlessRenderingEnabled = true;
            _cefSettings.LogSeverity = LogSeverity.Disable;

            Cef.Initialize(_cefSettings);

            // Load GarticHook
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "GarticHook.js"))
            {
                GarticHook = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "GarticHook.js");
            } else
            {
                MessageBox.Show("GarticHook.js could not be found!");
                Load += (s, e) => Close();
            }
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            AddClient();
        }

        private void AddClient()
        {
            BrowserSettings browserSettings = new BrowserSettings { WindowlessFrameRate = 1 };
            RequestContextSettings requestContextSettings = new RequestContextSettings { CachePath = "" };
            RequestContext requestContext = new RequestContext(requestContextSettings);
            ChromiumWebBrowser browser = new ChromiumWebBrowser("https://gartic.io/" + txtCode.Text, browserSettings, requestContext);

            browser.ExecuteScriptAsyncWhenPageLoaded(GarticHook);

            _bots.Add(new Bot(browser));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.WaitForBrowsersToClose();
            Cef.Shutdown();
        }

        private void btnRemoveClient_Click(object sender, EventArgs e)
        {
            if (_bots.Count > 0)
            {
                // _bots.Last().Dispose();
                // _bots.RemoveAt(_bots.Count - 1);

                Bot selectedBot = listClients.SelectedItem as Bot;
                if (selectedBot != null)
                {
                    selectedBot.Destroy();
                    _bots.Remove(selectedBot);
                }

            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                // TODO: Join with avatar
                bot.Join();
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                // TODO: This is stupid. Can we do this with bot.Leave?
                bot.Join(txtCode.Text);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.Report();
            }
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.Kick(txtKickUser.Text);
            }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.Hint();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.Skip();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                string bAnswer = bot.GetAnswer();
                if (bAnswer != null)
                {
                    MessageBox.Show("The answer is:\n" + bAnswer);
                    return;
                }
            }

            MessageBox.Show("We aren't drawing right now!");
        }

        private void btnRemoveAllClients_Click(object sender, EventArgs e)
        {
            while (_bots.Count > 0)
            {
                _bots.Last().Destroy();
                _bots.RemoveAt(_bots.Count - 1);
            }
        }

        private void btnInvade_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                AddClient();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void tmrUpdateList_Tick(object sender, EventArgs e)
        {
            RefreshList();
        }

        /* Update Bot-List */
        public void RefreshList()
        {
            listClients.DrawMode = DrawMode.OwnerDrawFixed;
            listClients.DrawMode = DrawMode.Normal;
        }
    }
}
