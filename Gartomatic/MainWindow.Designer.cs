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
            this.numAvatar = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvade = new System.Windows.Forms.Button();
            this.btnRemoveAllClients = new System.Windows.Forms.Button();
            this.btnRemoveClient = new System.Windows.Forms.Button();
            this.clientGroup = new System.Windows.Forms.GroupBox();
            this.listClients = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtKickUser = new System.Windows.Forms.TextBox();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.btnKick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tmrUpdateList = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).BeginInit();
            this.clientGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.numAvatar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnInvade);
            this.groupBox1.Controls.Add(this.btnRemoveAllClients);
            this.groupBox1.Controls.Add(this.btnRemoveClient);
            this.groupBox1.Controls.Add(this.btnAddClient);
            this.groupBox1.Location = new System.Drawing.Point(17, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // numAvatar
            // 
            this.numAvatar.Font = new System.Drawing.Font("Roboto", 16F);
            this.numAvatar.Location = new System.Drawing.Point(102, 102);
            this.numAvatar.Maximum = new decimal(new int[] {
            37,
            0,
            0,
            0});
            this.numAvatar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAvatar.Name = "numAvatar";
            this.numAvatar.Size = new System.Drawing.Size(231, 33);
            this.numAvatar.TabIndex = 11;
            this.numAvatar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14F);
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Avatar-ID:";
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
            this.clientGroup.Location = new System.Drawing.Point(742, 12);
            this.clientGroup.Name = "clientGroup";
            this.clientGroup.Size = new System.Drawing.Size(510, 657);
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
            this.listClients.Size = new System.Drawing.Size(504, 636);
            this.listClients.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.txtKickUser);
            this.groupBox2.Controls.Add(this.btnSkip);
            this.groupBox2.Controls.Add(this.btnHint);
            this.groupBox2.Controls.Add(this.btnAnswer);
            this.groupBox2.Controls.Add(this.btnKick);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnReport);
            this.groupBox2.Controls.Add(this.btnLeave);
            this.groupBox2.Controls.Add(this.btnJoin);
            this.groupBox2.Location = new System.Drawing.Point(17, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 450);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
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
            // btnSkip
            // 
            this.btnSkip.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSkip.Location = new System.Drawing.Point(171, 266);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(162, 36);
            this.btnSkip.TabIndex = 9;
            this.btnSkip.Text = "Skip";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnHint
            // 
            this.btnHint.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHint.Location = new System.Drawing.Point(6, 266);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(162, 36);
            this.btnHint.TabIndex = 8;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = true;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswer.Location = new System.Drawing.Point(6, 224);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(327, 36);
            this.btnAnswer.TabIndex = 7;
            this.btnAnswer.Text = "Get Answer";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
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
            this.btnLeave.Size = new System.Drawing.Size(327, 36);
            this.btnLeave.TabIndex = 3;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(6, 21);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(327, 36);
            this.btnJoin.TabIndex = 2;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(638, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 36);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvatar)).EndInit();
            this.clientGroup.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown numAvatar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer tmrUpdateList;
    }
}

