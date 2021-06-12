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
            Rejoin();
        }

        private void Rejoin()
        {
            foreach (Bot bot in _bots)
            {
                string bStatus = bot.GetStatus();
                if (bStatus != "Drawing" && bStatus != "In-Game")
                {
                    bot.Join(txtCode.Text);
                }
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.Leave();
            }

            tmrRejoin.Enabled = false;
            chkAutoRejoin.Checked = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportAll();
        }

        private void ReportAll()
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
            SkipAll();
        }

        private void SkipAll()
        {
            foreach (Bot bot in _bots)
            {
                bot.Skip();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string bAnswer = GetAnswer();
            if (!String.IsNullOrEmpty(bAnswer))
            {
                txtAnswer.Text = bAnswer;
                MessageBox.Show("The answer is:\n" + bAnswer);
            } else
            {
                MessageBox.Show("We aren't drawing right now!");
            }
        }

        private string GetAnswer()
        {
            foreach (Bot bot in _bots)
            {
                string bAnswer = bot.GetAnswer();
                if (!String.IsNullOrEmpty(bAnswer))
                {
                    return bAnswer;
                }
            }

            return null;
        }

        private void btnRemoveAllClients_Click(object sender, EventArgs e)
        {
            while (_bots.Count > 0)
            {
                _bots.Last().Destroy();
                _bots.RemoveAt(_bots.Count - 1);
            }
        }

        /* Invade a lobby with 10 bots */
        private async void btnInvade_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                AddClient();
                await Task.Delay(120);
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

        private void chkAutoReport_CheckedChanged(object sender, EventArgs e)
        {
            tmrReport.Enabled = chkAutoReport.Checked;
        }

        private void chkAutoSkip_CheckedChanged(object sender, EventArgs e)
        {
            tmrSkip.Enabled = chkAutoSkip.Checked;
        }

        private void tmrReport_Tick(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                if (bot.GetStatus() == "Drawing")
                {
                    return;
                }
            }

            ReportAll();
        }

        private void tmrSkip_Tick(object sender, EventArgs e)
        {
            SkipAll();
        }

        private void btnClearBots_Click(object sender, EventArgs e)
        {
            bool isDone = false;
            int currentBot = 0;

            while (!isDone)
            {
                if (currentBot > _bots.Count) { isDone = true; break; }

                string bStatus = _bots[currentBot].GetStatus();
                if (bStatus != "Drawing" && bStatus != "In-Game")
                {
                    _bots[currentBot].Destroy();
                    _bots.RemoveAt(currentBot);
                }
            }
        }

        private void chkAutoRejoin_CheckedChanged(object sender, EventArgs e)
        {
            tmrRejoin.Enabled = chkAutoRejoin.Checked;
        }

        private void tmrRejoin_Tick(object sender, EventArgs e)
        {
            Rejoin();
        }

        private void btnSendChat_Click(object sender, EventArgs e)
        {
            SendChatAll(txtChat.Text);
        }

        private void SendChatAll(string pMessage)
        {
            Random rnd = new Random();

            foreach (Bot bot in _bots)
            {
                bot.SendChat(pMessage + " " + rnd.Next(10, 99));
            }
        }

        private void btnSendAnswer_Click(object sender, EventArgs e)
        {
            foreach (Bot bot in _bots)
            {
                bot.SendAnswer(txtAnswer.Text);
            }
        }

        private void btnJoinSingle_Click(object sender, EventArgs e)
        {
            Bot selectedBot = listClients.SelectedItem as Bot;
            selectedBot.Join(txtCode.Text);
        }

        private void btnLeaveSingle_Click(object sender, EventArgs e)
        {
            Bot selectedBot = listClients.SelectedItem as Bot;
            selectedBot.Leave();
        }

        private void chkAutoAnswer_CheckedChanged(object sender, EventArgs e)
        {
            tmrAnswer.Enabled = chkAutoAnswer.Checked;
        }

        private void tmrAnswer_Tick(object sender, EventArgs e)
        {
            string bAnswer = GetAnswer();
            if (!String.IsNullOrEmpty(bAnswer))
            {
                foreach (Bot bot in _bots)
                {
                    bot.SendAnswer(bAnswer);
                }
            }
        }

        /* Strip URL from RoomID */
        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            if (txtCode.Text.Contains("https://gartic.io/"))
            {
                txtCode.Text = txtCode.Text.Replace("https://gartic.io/", "");
            }
        }

        private void chkChatspam_CheckedChanged(object sender, EventArgs e)
        {
            tmrChatspam.Enabled = chkChatspam.Checked;
        }

        private void tmrChatspam_Tick(object sender, EventArgs e)
        {
            SendChatAll(txtChatspam.Text);
        }
    }
}
