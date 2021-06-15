namespace Gartomatic
{
    partial class MainWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInvade = new System.Windows.Forms.Button();
            this.btnRemoveAllClients = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.clientGroup = new System.Windows.Forms.GroupBox();
            this.listClients = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendChat = new System.Windows.Forms.Button();
            this.btnLeaveSingle = new System.Windows.Forms.Button();
            this.btnJoinSingle = new System.Windows.Forms.Button();
            this.btnSendAnswer = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.btnClearBots = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.txtKickUser = new System.Windows.Forms.TextBox();
            this.btnKick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrUpdateList = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkChatspam = new System.Windows.Forms.CheckBox();
            this.txtChatspam = new System.Windows.Forms.TextBox();
            this.chkAutoAnswer = new System.Windows.Forms.CheckBox();
            this.chkAutoRejoin = new System.Windows.Forms.CheckBox();
            this.chkAutoSkip = new System.Windows.Forms.CheckBox();
            this.chkAutoReport = new System.Windows.Forms.CheckBox();
            this.tmrReport = new System.Windows.Forms.Timer(this.components);
            this.tmrSkip = new System.Windows.Forms.Timer(this.components);
            this.tmrRejoin = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tmrAnswer = new System.Windows.Forms.Timer(this.components);
            this.tmrChatspam = new System.Windows.Forms.Timer(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAutobotRemove = new System.Windows.Forms.Button();
            this.btnAutobotAdd = new System.Windows.Forms.Button();
            this.txtAutobotRoom = new System.Windows.Forms.TextBox();
            this.listAutobotRooms = new System.Windows.Forms.ListBox();
            this.chkAutobotQueue = new System.Windows.Forms.CheckBox();
            this.chkAutobot = new System.Windows.Forms.CheckBox();
            this.tmrAutobot = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.clientGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtCode.Location = new System.Drawing.Point(143, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 33);
            this.txtCode.TabIndex = 0;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game Code:";
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(6, 21);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(162, 36);
            this.btnAddClient.TabIndex = 2;
            this.btnAddClient.Text = "Add";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInvade);
            this.groupBox1.Controls.Add(this.btnRemoveAllClients);
            this.groupBox1.Controls.Add(this.btnRemoveClient);
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Location = new System.Drawing.Point(17, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 113);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // btnInvade
            // 
            this.btnInvade.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvade.Location = new System.Drawing.Point(171, 21);
            this.btnInvade.Name = "btnInvade";
            this.btnInvade.Size = new System.Drawing.Size(162, 36);
            this.btnInvade.TabIndex = 5;
            this.btnInvade.Text = "Invade";
            this.btnInvade.UseVisualStyleBackColor = true;
            this.btnInvade.Click += new System.EventHandler(this.btnInvade_Click);
            // 
            // btnRemoveAllClients
            // 
            this.btnRemoveAllClients.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveAllClients.Location = new System.Drawing.Point(171, 63);
            this.btnRemoveAllClients.Name = "btnRemoveAllClients";
            this.btnRemoveAllClients.Size = new System.Drawing.Size(162, 36);
            this.btnRemoveAllClients.TabIndex = 4;
            this.btnRemoveAllClients.Text = "Remove All";
            this.btnRemoveAllClients.UseVisualStyleBackColor = true;
            this.btnRemoveAllClients.Click += new System.EventHandler(this.btnRemoveAllClients_Click);
            // 
            // btnRemoveClient
            // 
            this.btnRemoveClient.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveClient.Location = new System.Drawing.Point(6, 63);
            this.btnRemoveClient.Name = "btnRemoveClient";
            this.btnRemoveClient.Size = new System.Drawing.Size(162, 36);
            this.btnRemoveClient.TabIndex = 3;
            this.btnRemoveClient.Text = "Remove";
            this.btnRemoveClient.UseVisualStyleBackColor = true;
            this.btnRemoveClient.Click += new System.EventHandler(this.btnRemoveClient_Click);
            // 
            // clientGroup
            // 
            this.clientGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clientGroup.Controls.Add(this.listClients);
            this.clientGroup.Location = new System.Drawing.Point(742, 48);
            this.clientGroup.Name = "clientGroup";
            this.clientGroup.Size = new System.Drawing.Size(510, 621);
            this.clientGroup.TabIndex = 4;
            this.clientGroup.TabStop = false;
            this.clientGroup.Text = "Clients";
            // 
            // listClients
            // 
            this.listClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClients.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listClients.FormattingEnabled = true;
            this.listClients.ItemHeight = 19;
            this.listClients.Location = new System.Drawing.Point(3, 18);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(504, 600);
            this.listClients.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btnSendChat);
            this.groupBox2.Controls.Add(this.btnLeaveSingle);
            this.groupBox2.Controls.Add(this.btnJoinSingle);
            this.groupBox2.Controls.Add(this.btnSendAnswer);
            this.groupBox2.Controls.Add(this.txtChat);
            this.groupBox2.Controls.Add(this.btnClearBots);
            this.groupBox2.Controls.Add(this.txtAnswer);
            this.groupBox2.Controls.Add(this.txtKickUser);
            this.groupBox2.Controls.Add(this.btnKick);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.btnLeave);
            this.groupBox2.Controls.Add(this.btnJoin);
            this.groupBox2.Location = new System.Drawing.Point(17, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 347);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnSendChat
            // 
            this.btnSendChat.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendChat.Location = new System.Drawing.Point(237, 266);
            this.btnSendChat.Name = "btnSendChat";
            this.btnSendChat.Size = new System.Drawing.Size(96, 33);
            this.btnSendChat.TabIndex = 13;
            this.btnSendChat.Text = "Chat";
            this.btnSendChat.UseVisualStyleBackColor = true;
            this.btnSendChat.Click += new System.EventHandler(this.btnSendChat_Click);
            // 
            // btnLeaveSingle
            // 
            this.btnLeaveSingle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveSingle.Location = new System.Drawing.Point(171, 63);
            this.btnLeaveSingle.Name = "btnLeaveSingle";
            this.btnLeaveSingle.Size = new System.Drawing.Size(162, 36);
            this.btnLeaveSingle.TabIndex = 18;
            this.btnLeaveSingle.Text = "Leave";
            this.btnLeaveSingle.UseVisualStyleBackColor = true;
            this.btnLeaveSingle.Click += new System.EventHandler(this.btnLeaveSingle_Click);
            // 
            // btnJoinSingle
            // 
            this.btnJoinSingle.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinSingle.Location = new System.Drawing.Point(171, 21);
            this.btnJoinSingle.Name = "btnJoinSingle";
            this.btnJoinSingle.Size = new System.Drawing.Size(162, 36);
            this.btnJoinSingle.TabIndex = 17;
            this.btnJoinSingle.Text = "Join";
            this.btnJoinSingle.UseVisualStyleBackColor = true;
            this.btnJoinSingle.Click += new System.EventHandler(this.btnJoinSingle_Click);
            // 
            // btnSendAnswer
            // 
            this.btnSendAnswer.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendAnswer.Location = new System.Drawing.Point(237, 305);
            this.btnSendAnswer.Name = "btnSendAnswer";
            this.btnSendAnswer.Size = new System.Drawing.Size(96, 33);
            this.btnSendAnswer.TabIndex = 15;
            this.btnSendAnswer.Text = "Answer";
            this.btnSendAnswer.UseVisualStyleBackColor = true;
            this.btnSendAnswer.Click += new System.EventHandler(this.btnSendAnswer_Click);
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtChat.Location = new System.Drawing.Point(6, 266);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(225, 33);
            this.txtChat.TabIndex = 12;
            this.txtChat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClearBots
            // 
            this.btnClearBots.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBots.Location = new System.Drawing.Point(6, 224);
            this.btnClearBots.Name = "btnClearBots";
            this.btnClearBots.Size = new System.Drawing.Size(327, 36);
            this.btnClearBots.TabIndex = 11;
            this.btnClearBots.Text = "Clear Unused Bots";
            this.btnClearBots.UseVisualStyleBackColor = true;
            this.btnClearBots.Click += new System.EventHandler(this.btnClearBots_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtAnswer.Location = new System.Drawing.Point(6, 305);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(225, 33);
            this.txtAnswer.TabIndex = 14;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtKickUser
            // 
            this.txtKickUser.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtKickUser.Location = new System.Drawing.Point(65, 146);
            this.txtKickUser.Name = "txtKickUser";
            this.txtKickUser.Size = new System.Drawing.Size(268, 33);
            this.txtKickUser.TabIndex = 5;
            this.txtKickUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKick
            // 
            this.btnKick.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKick.Location = new System.Drawing.Point(6, 185);
            this.btnKick.Name = "btnKick";
            this.btnKick.Size = new System.Drawing.Size(327, 33);
            this.btnKick.TabIndex = 6;
            this.btnKick.Text = "Kick";
            this.btnKick.UseVisualStyleBackColor = true;
            this.btnKick.Click += new System.EventHandler(this.btnKick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14F);
            this.label2.Location = new System.Drawing.Point(6, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "User:";
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(6, 105);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(327, 36);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Report Drawing";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(6, 63);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(162, 36);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave All";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(6, 21);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(162, 36);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join All";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(6, 105);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(327, 36);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(6, 63);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(327, 36);
            this.btnHint.TabIndex = 8;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(6, 21);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(327, 36);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Get Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(745, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(504, 36);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tmrUpdateList
            // 
            this.tmrUpdateList.Enabled = true;
            this.tmrUpdateList.Interval = 5000;
            this.tmrUpdateList.Tick += new System.EventHandler(this.tmrUpdateList_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkChatspam);
            this.groupBox3.Controls.Add(this.txtChatspam);
            this.groupBox3.Controls.Add(this.chkAutoAnswer);
            this.groupBox3.Controls.Add(this.chkAutoRejoin);
            this.groupBox3.Controls.Add(this.chkAutoSkip);
            this.groupBox3.Controls.Add(this.chkAutoReport);
            this.groupBox3.Location = new System.Drawing.Point(362, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 199);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bot";
            // 
            // chkChatspam
            // 
            this.chkChatspam.AutoSize = true;
            this.chkChatspam.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkChatspam.Location = new System.Drawing.Point(30, 119);
            this.chkChatspam.Name = "chkChatspam";
            this.chkChatspam.Size = new System.Drawing.Size(177, 27);
            this.chkChatspam.TabIndex = 20;
            this.chkChatspam.Text = "Enable Chatspam";
            this.chkChatspam.UseVisualStyleBackColor = true;
            this.chkChatspam.CheckedChanged += new System.EventHandler(this.chkChatspam_CheckedChanged);
            // 
            // txtChatspam
            // 
            this.txtChatspam.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtChatspam.Location = new System.Drawing.Point(30, 152);
            this.txtChatspam.Name = "txtChatspam";
            this.txtChatspam.Size = new System.Drawing.Size(268, 33);
            this.txtChatspam.TabIndex = 19;
            this.txtChatspam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkAutoAnswer
            // 
            this.chkAutoAnswer.AutoSize = true;
            this.chkAutoAnswer.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutoAnswer.Location = new System.Drawing.Point(213, 70);
            this.chkAutoAnswer.Name = "chkAutoAnswer";
            this.chkAutoAnswer.Size = new System.Drawing.Size(135, 27);
            this.chkAutoAnswer.TabIndex = 3;
            this.chkAutoAnswer.Text = "Auto Answer";
            this.chkAutoAnswer.UseVisualStyleBackColor = true;
            this.chkAutoAnswer.CheckedChanged += new System.EventHandler(this.chkAutoAnswer_CheckedChanged);
            // 
            // chkAutoRejoin
            // 
            this.chkAutoRejoin.AutoSize = true;
            this.chkAutoRejoin.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutoRejoin.Location = new System.Drawing.Point(30, 70);
            this.chkAutoRejoin.Name = "chkAutoRejoin";
            this.chkAutoRejoin.Size = new System.Drawing.Size(126, 27);
            this.chkAutoRejoin.TabIndex = 2;
            this.chkAutoRejoin.Text = "Auto Rejoin";
            this.chkAutoRejoin.UseVisualStyleBackColor = true;
            this.chkAutoRejoin.CheckedChanged += new System.EventHandler(this.chkAutoRejoin_CheckedChanged);
            // 
            // chkAutoSkip
            // 
            this.chkAutoSkip.AutoSize = true;
            this.chkAutoSkip.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutoSkip.Location = new System.Drawing.Point(213, 28);
            this.chkAutoSkip.Name = "chkAutoSkip";
            this.chkAutoSkip.Size = new System.Drawing.Size(110, 27);
            this.chkAutoSkip.TabIndex = 1;
            this.chkAutoSkip.Text = "Auto Skip";
            this.chkAutoSkip.UseVisualStyleBackColor = true;
            this.chkAutoSkip.CheckedChanged += new System.EventHandler(this.chkAutoSkip_CheckedChanged);
            // 
            // chkAutoReport
            // 
            this.chkAutoReport.AutoSize = true;
            this.chkAutoReport.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutoReport.Location = new System.Drawing.Point(30, 28);
            this.chkAutoReport.Name = "chkAutoReport";
            this.chkAutoReport.Size = new System.Drawing.Size(129, 27);
            this.chkAutoReport.TabIndex = 0;
            this.chkAutoReport.Text = "Auto Report";
            this.chkAutoReport.UseVisualStyleBackColor = true;
            this.chkAutoReport.CheckedChanged += new System.EventHandler(this.chkAutoReport_CheckedChanged);
            // 
            // tmrReport
            // 
            this.tmrReport.Interval = 10000;
            this.tmrReport.Tick += new System.EventHandler(this.tmrReport_Tick);
            // 
            // tmrSkip
            // 
            this.tmrSkip.Interval = 10000;
            this.tmrSkip.Tick += new System.EventHandler(this.tmrSkip_Tick);
            // 
            // tmrRejoin
            // 
            this.tmrRejoin.Interval = 10000;
            this.tmrRejoin.Tick += new System.EventHandler(this.tmrRejoin_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAnswer);
            this.groupBox4.Controls.Add(this.btnHint);
            this.groupBox4.Controls.Add(this.btnSkip);
            this.groupBox4.Location = new System.Drawing.Point(17, 520);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(339, 149);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Drawer Tools";
            // 
            // tmrAnswer
            // 
            this.tmrAnswer.Interval = 10000;
            this.tmrAnswer.Tick += new System.EventHandler(this.tmrAnswer_Tick);
            // 
            // tmrChatspam
            // 
            this.tmrChatspam.Interval = 10000;
            this.tmrChatspam.Tick += new System.EventHandler(this.tmrChatspam_Tick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAutobotRemove);
            this.groupBox5.Controls.Add(this.btnAutobotAdd);
            this.groupBox5.Controls.Add(this.txtAutobotRoom);
            this.groupBox5.Controls.Add(this.listAutobotRooms);
            this.groupBox5.Controls.Add(this.chkAutobotQueue);
            this.groupBox5.Controls.Add(this.chkAutobot);
            this.groupBox5.Location = new System.Drawing.Point(362, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 296);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Auto-Bot";
            // 
            // btnAutobotRemove
            // 
            this.btnAutobotRemove.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobotRemove.Location = new System.Drawing.Point(303, 242);
            this.btnAutobotRemove.Name = "btnAutobotRemove";
            this.btnAutobotRemove.Size = new System.Drawing.Size(33, 33);
            this.btnAutobotRemove.TabIndex = 24;
            this.btnAutobotRemove.Text = "-";
            this.btnAutobotRemove.UseVisualStyleBackColor = true;
            this.btnAutobotRemove.Click += new System.EventHandler(this.btnAutobotRemove_Click);
            // 
            // btnAutobotAdd
            // 
            this.btnAutobotAdd.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutobotAdd.Location = new System.Drawing.Point(264, 242);
            this.btnAutobotAdd.Name = "btnAutobotAdd";
            this.btnAutobotAdd.Size = new System.Drawing.Size(33, 33);
            this.btnAutobotAdd.TabIndex = 19;
            this.btnAutobotAdd.Text = "+";
            this.btnAutobotAdd.UseVisualStyleBackColor = true;
            this.btnAutobotAdd.Click += new System.EventHandler(this.btnAutobotAdd_Click);
            // 
            // txtAutobotRoom
            // 
            this.txtAutobotRoom.Font = new System.Drawing.Font("Roboto", 16F);
            this.txtAutobotRoom.Location = new System.Drawing.Point(30, 242);
            this.txtAutobotRoom.Name = "txtAutobotRoom";
            this.txtAutobotRoom.Size = new System.Drawing.Size(228, 33);
            this.txtAutobotRoom.TabIndex = 21;
            this.txtAutobotRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listAutobotRooms
            // 
            this.listAutobotRooms.FormattingEnabled = true;
            this.listAutobotRooms.ItemHeight = 14;
            this.listAutobotRooms.Location = new System.Drawing.Point(30, 92);
            this.listAutobotRooms.Name = "listAutobotRooms";
            this.listAutobotRooms.Size = new System.Drawing.Size(318, 144);
            this.listAutobotRooms.TabIndex = 23;
            // 
            // chkAutobotQueue
            // 
            this.chkAutobotQueue.AutoSize = true;
            this.chkAutobotQueue.Checked = true;
            this.chkAutobotQueue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutobotQueue.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutobotQueue.Location = new System.Drawing.Point(30, 59);
            this.chkAutobotQueue.Name = "chkAutobotQueue";
            this.chkAutobotQueue.Size = new System.Drawing.Size(119, 27);
            this.chkAutobotQueue.TabIndex = 22;
            this.chkAutobotQueue.Text = "Use Queue";
            this.chkAutobotQueue.UseVisualStyleBackColor = true;
            this.chkAutobotQueue.CheckedChanged += new System.EventHandler(this.chkAutobotQueue_CheckedChanged);
            // 
            // chkAutobot
            // 
            this.chkAutobot.AutoSize = true;
            this.chkAutobot.Font = new System.Drawing.Font("Roboto", 14F);
            this.chkAutobot.Location = new System.Drawing.Point(30, 26);
            this.chkAutobot.Name = "chkAutobot";
            this.chkAutobot.Size = new System.Drawing.Size(189, 27);
            this.chkAutobot.TabIndex = 21;
            this.chkAutobot.Text = "Enable Automation";
            this.chkAutobot.UseVisualStyleBackColor = true;
            this.chkAutobot.CheckedChanged += new System.EventHandler(this.chkAutobot_CheckedChanged);
            // 
            // tmrAutobot
            // 
            this.tmrAutobot.Interval = 60000;
            this.tmrAutobot.Tick += new System.EventHandler(this.tmrAutobot_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clientGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCode);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gartomatic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.clientGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveClient;
        private System.Windows.Forms.GroupBox clientGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKick;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Button btnRemoveAllClients;
        private System.Windows.Forms.Button btnInvade;
        private System.Windows.Forms.TextBox txtKickUser;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrUpdateList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkAutoSkip;
        private System.Windows.Forms.CheckBox chkAutoReport;
        private System.Windows.Forms.Timer tmrReport;
        private System.Windows.Forms.Timer tmrSkip;
        private System.Windows.Forms.Button btnClearBots;
        private System.Windows.Forms.CheckBox chkAutoRejoin;
        private System.Windows.Forms.Timer tmrRejoin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSendAnswer;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnSendChat;
        private System.Windows.Forms.Button btnJoinSingle;
        private System.Windows.Forms.Button btnLeaveSingle;
        private System.Windows.Forms.CheckBox chkAutoAnswer;
        private System.Windows.Forms.Timer tmrAnswer;
        private System.Windows.Forms.CheckBox chkChatspam;
        private System.Windows.Forms.TextBox txtChatspam;
        private System.Windows.Forms.Timer tmrChatspam;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkAutobot;
        private System.Windows.Forms.Timer tmrAutobot;
        private System.Windows.Forms.CheckBox chkAutobotQueue;
        private System.Windows.Forms.Button btnAutobotRemove;
        private System.Windows.Forms.Button btnAutobotAdd;
        private System.Windows.Forms.TextBox txtAutobotRoom;
        private System.Windows.Forms.ListBox listAutobotRooms;
    }
}

