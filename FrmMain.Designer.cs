namespace CLsChat
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ChkSelectAll = new System.Windows.Forms.CheckBox();
            this.BtnSend = new System.Windows.Forms.Button();
            this.Lst = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.LblInboxFeedback = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnSearchInbox = new System.Windows.Forms.Button();
            this.TxtSenderSearchInbox = new System.Windows.Forms.TextBox();
            this.TxtSubjectSearchInbox = new System.Windows.Forms.TextBox();
            this.DtpEndDateInbox = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDateInbox = new System.Windows.Forms.DateTimePicker();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnMarkAsUnread = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.BtnMarkAsRead = new System.Windows.Forms.Button();
            this.gridInbox = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSearchSent = new System.Windows.Forms.Button();
            this.TxtSenderSearchSent = new System.Windows.Forms.TextBox();
            this.TxtSubjectSearchSent = new System.Windows.Forms.TextBox();
            this.DtpEndDateSent = new System.Windows.Forms.DateTimePicker();
            this.DtpStartDateSent = new System.Windows.Forms.DateTimePicker();
            this.gridSent = new System.Windows.Forms.DataGridView();
            this.LblSentFeedback = new System.Windows.Forms.Label();
            this.tabMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInbox)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSent)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage1);
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1259, 597);
            this.tabMain.TabIndex = 0;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ChkSelectAll);
            this.tabPage1.Controls.Add(this.BtnSend);
            this.tabPage1.Controls.Add(this.Lst);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtMessage);
            this.tabPage1.Controls.Add(this.TxtSubject);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1251, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New Message";
            // 
            // ChkSelectAll
            // 
            this.ChkSelectAll.AutoSize = true;
            this.ChkSelectAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChkSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkSelectAll.Location = new System.Drawing.Point(950, 27);
            this.ChkSelectAll.Margin = new System.Windows.Forms.Padding(4);
            this.ChkSelectAll.Name = "ChkSelectAll";
            this.ChkSelectAll.Size = new System.Drawing.Size(116, 29);
            this.ChkSelectAll.TabIndex = 4;
            this.ChkSelectAll.Text = "Select All";
            this.ChkSelectAll.UseVisualStyleBackColor = true;
            this.ChkSelectAll.CheckedChanged += new System.EventHandler(this.ChkSelectAll_CheckedChanged);
            // 
            // BtnSend
            // 
            this.BtnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.Location = new System.Drawing.Point(106, 514);
            this.BtnSend.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(180, 40);
            this.BtnSend.TabIndex = 6;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // Lst
            // 
            this.Lst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lst.FormattingEnabled = true;
            this.Lst.Location = new System.Drawing.Point(950, 71);
            this.Lst.Margin = new System.Windows.Forms.Padding(4);
            this.Lst.Name = "Lst";
            this.Lst.Size = new System.Drawing.Size(211, 429);
            this.Lst.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // TxtMessage
            // 
            this.TxtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMessage.Location = new System.Drawing.Point(106, 71);
            this.TxtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(816, 429);
            this.TxtMessage.TabIndex = 3;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubject.Location = new System.Drawing.Point(106, 27);
            this.TxtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(816, 34);
            this.TxtSubject.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.LblInboxFeedback);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.BtnSearchInbox);
            this.tabPage2.Controls.Add(this.TxtSenderSearchInbox);
            this.tabPage2.Controls.Add(this.TxtSubjectSearchInbox);
            this.tabPage2.Controls.Add(this.DtpEndDateInbox);
            this.tabPage2.Controls.Add(this.DtpStartDateInbox);
            this.tabPage2.Controls.Add(this.BtnRefresh);
            this.tabPage2.Controls.Add(this.BtnMarkAsUnread);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbFilter);
            this.tabPage2.Controls.Add(this.BtnMarkAsRead);
            this.tabPage2.Controls.Add(this.gridInbox);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1251, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inbox";
            // 
            // LblInboxFeedback
            // 
            this.LblInboxFeedback.AutoSize = true;
            this.LblInboxFeedback.BackColor = System.Drawing.Color.DarkGray;
            this.LblInboxFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInboxFeedback.Location = new System.Drawing.Point(81, 231);
            this.LblInboxFeedback.Name = "LblInboxFeedback";
            this.LblInboxFeedback.Size = new System.Drawing.Size(727, 85);
            this.LblInboxFeedback.TabIndex = 20;
            this.LblInboxFeedback.Text = "No messages found.";
            this.LblInboxFeedback.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(892, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(892, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Subject:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(892, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(892, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Start Date:";
            // 
            // BtnSearchInbox
            // 
            this.BtnSearchInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchInbox.Location = new System.Drawing.Point(993, 472);
            this.BtnSearchInbox.Name = "BtnSearchInbox";
            this.BtnSearchInbox.Size = new System.Drawing.Size(150, 35);
            this.BtnSearchInbox.TabIndex = 15;
            this.BtnSearchInbox.Text = "Search";
            this.BtnSearchInbox.UseVisualStyleBackColor = true;
            this.BtnSearchInbox.Click += new System.EventHandler(this.BtnSearchInbox_Click);
            // 
            // TxtSenderSearchInbox
            // 
            this.TxtSenderSearchInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenderSearchInbox.Location = new System.Drawing.Point(913, 410);
            this.TxtSenderSearchInbox.Name = "TxtSenderSearchInbox";
            this.TxtSenderSearchInbox.Size = new System.Drawing.Size(331, 28);
            this.TxtSenderSearchInbox.TabIndex = 14;
            // 
            // TxtSubjectSearchInbox
            // 
            this.TxtSubjectSearchInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubjectSearchInbox.Location = new System.Drawing.Point(913, 320);
            this.TxtSubjectSearchInbox.Name = "TxtSubjectSearchInbox";
            this.TxtSubjectSearchInbox.Size = new System.Drawing.Size(331, 28);
            this.TxtSubjectSearchInbox.TabIndex = 13;
            // 
            // DtpEndDateInbox
            // 
            this.DtpEndDateInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDateInbox.Location = new System.Drawing.Point(913, 230);
            this.DtpEndDateInbox.Name = "DtpEndDateInbox";
            this.DtpEndDateInbox.Size = new System.Drawing.Size(331, 28);
            this.DtpEndDateInbox.TabIndex = 12;
            // 
            // DtpStartDateInbox
            // 
            this.DtpStartDateInbox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDateInbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDateInbox.Location = new System.Drawing.Point(913, 140);
            this.DtpStartDateInbox.Name = "DtpStartDateInbox";
            this.DtpStartDateInbox.Size = new System.Drawing.Size(331, 28);
            this.DtpStartDateInbox.TabIndex = 11;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.Location = new System.Drawing.Point(10, 522);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(150, 35);
            this.BtnRefresh.TabIndex = 10;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnMarkAsUnread
            // 
            this.BtnMarkAsUnread.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMarkAsUnread.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkAsUnread.Location = new System.Drawing.Point(702, 522);
            this.BtnMarkAsUnread.Name = "BtnMarkAsUnread";
            this.BtnMarkAsUnread.Size = new System.Drawing.Size(180, 35);
            this.BtnMarkAsUnread.TabIndex = 9;
            this.BtnMarkAsUnread.Text = "Mark as Unread";
            this.BtnMarkAsUnread.UseVisualStyleBackColor = true;
            this.BtnMarkAsUnread.Click += new System.EventHandler(this.BtnMarkAsUnread_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter By:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(109, 7);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 33);
            this.cmbFilter.TabIndex = 7;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.CmbFilter_SelectedIndexChanged);
            // 
            // BtnMarkAsRead
            // 
            this.BtnMarkAsRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMarkAsRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkAsRead.Location = new System.Drawing.Point(494, 522);
            this.BtnMarkAsRead.Name = "BtnMarkAsRead";
            this.BtnMarkAsRead.Size = new System.Drawing.Size(180, 35);
            this.BtnMarkAsRead.TabIndex = 5;
            this.BtnMarkAsRead.Text = "Mark as Read";
            this.BtnMarkAsRead.UseVisualStyleBackColor = true;
            this.BtnMarkAsRead.Click += new System.EventHandler(this.BtnMarkAsRead_Click);
            // 
            // gridInbox
            // 
            this.gridInbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInbox.Location = new System.Drawing.Point(10, 50);
            this.gridInbox.Margin = new System.Windows.Forms.Padding(4);
            this.gridInbox.Name = "gridInbox";
            this.gridInbox.RowHeadersWidth = 51;
            this.gridInbox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridInbox.Size = new System.Drawing.Size(872, 457);
            this.gridInbox.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.LblSentFeedback);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.BtnSearchSent);
            this.tabPage3.Controls.Add(this.TxtSenderSearchSent);
            this.tabPage3.Controls.Add(this.TxtSubjectSearchSent);
            this.tabPage3.Controls.Add(this.DtpEndDateSent);
            this.tabPage3.Controls.Add(this.DtpStartDateSent);
            this.tabPage3.Controls.Add(this.gridSent);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1251, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sent";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(892, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Recipient:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(892, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "Subject:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(892, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 26;
            this.label10.Text = "End Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(892, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 25);
            this.label11.TabIndex = 25;
            this.label11.Text = "Start Date:";
            // 
            // BtnSearchSent
            // 
            this.BtnSearchSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearchSent.Location = new System.Drawing.Point(993, 472);
            this.BtnSearchSent.Name = "BtnSearchSent";
            this.BtnSearchSent.Size = new System.Drawing.Size(150, 35);
            this.BtnSearchSent.TabIndex = 24;
            this.BtnSearchSent.Text = "Search";
            this.BtnSearchSent.UseVisualStyleBackColor = true;
            this.BtnSearchSent.Click += new System.EventHandler(this.BtnSearchSent_Click);
            // 
            // TxtSenderSearchSent
            // 
            this.TxtSenderSearchSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenderSearchSent.Location = new System.Drawing.Point(913, 410);
            this.TxtSenderSearchSent.Name = "TxtSenderSearchSent";
            this.TxtSenderSearchSent.Size = new System.Drawing.Size(331, 28);
            this.TxtSenderSearchSent.TabIndex = 23;
            // 
            // TxtSubjectSearchSent
            // 
            this.TxtSubjectSearchSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubjectSearchSent.Location = new System.Drawing.Point(913, 320);
            this.TxtSubjectSearchSent.Name = "TxtSubjectSearchSent";
            this.TxtSubjectSearchSent.Size = new System.Drawing.Size(331, 28);
            this.TxtSubjectSearchSent.TabIndex = 22;
            // 
            // DtpEndDateSent
            // 
            this.DtpEndDateSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpEndDateSent.Location = new System.Drawing.Point(913, 230);
            this.DtpEndDateSent.Name = "DtpEndDateSent";
            this.DtpEndDateSent.Size = new System.Drawing.Size(331, 28);
            this.DtpEndDateSent.TabIndex = 21;
            // 
            // DtpStartDateSent
            // 
            this.DtpStartDateSent.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDateSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpStartDateSent.Location = new System.Drawing.Point(913, 140);
            this.DtpStartDateSent.Name = "DtpStartDateSent";
            this.DtpStartDateSent.Size = new System.Drawing.Size(331, 28);
            this.DtpStartDateSent.TabIndex = 20;
            // 
            // gridSent
            // 
            this.gridSent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSent.Location = new System.Drawing.Point(10, 50);
            this.gridSent.Margin = new System.Windows.Forms.Padding(4);
            this.gridSent.Name = "gridSent";
            this.gridSent.RowHeadersWidth = 51;
            this.gridSent.Size = new System.Drawing.Size(872, 457);
            this.gridSent.TabIndex = 5;
            // 
            // LblSentFeedback
            // 
            this.LblSentFeedback.AutoSize = true;
            this.LblSentFeedback.BackColor = System.Drawing.Color.DarkGray;
            this.LblSentFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSentFeedback.Location = new System.Drawing.Point(81, 231);
            this.LblSentFeedback.Name = "LblSentFeedback";
            this.LblSentFeedback.Size = new System.Drawing.Size(727, 85);
            this.LblSentFeedback.TabIndex = 29;
            this.LblSentFeedback.Text = "No messages found.";
            this.LblSentFeedback.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 603);
            this.Controls.Add(this.tabMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = " CLS G1 Chat App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInbox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.CheckedListBox Lst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.CheckBox ChkSelectAll;
        private System.Windows.Forms.DataGridView gridInbox;
        private System.Windows.Forms.DataGridView gridSent;
        private System.Windows.Forms.Button BtnMarkAsRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button BtnMarkAsUnread;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSearchInbox;
        private System.Windows.Forms.TextBox TxtSenderSearchInbox;
        private System.Windows.Forms.TextBox TxtSubjectSearchInbox;
        private System.Windows.Forms.DateTimePicker DtpEndDateInbox;
        private System.Windows.Forms.DateTimePicker DtpStartDateInbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnSearchSent;
        private System.Windows.Forms.TextBox TxtSenderSearchSent;
        private System.Windows.Forms.TextBox TxtSubjectSearchSent;
        private System.Windows.Forms.DateTimePicker DtpEndDateSent;
        private System.Windows.Forms.DateTimePicker DtpStartDateSent;
        private System.Windows.Forms.Label LblInboxFeedback;
        private System.Windows.Forms.Label LblSentFeedback;
    }
}