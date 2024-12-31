using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace CLsChat
{
    public partial class FrmMain : Form
    {
        private Dictionary<int, string> userDictionary = new Dictionary<int, string>();
        private enum Filter
        {
            All,
            Read,
            Unread
        }

        public FrmMain()
        {
            InitializeComponent();
        }
        // Helper Functions
        private void ClearControls(Control parentControl)
        {
            foreach (Control ctrl in parentControl.Controls)
            {
                if (ctrl is TextBox txt)
                {
                    txt.Text = "";
                }
                else if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedIndex = 0;
                }
                else if (ctrl is CheckBox chk)
                {
                    chk.Checked = false;
                }
                else if (ctrl is DateTimePicker dtp)
                {
                    dtp.Value = DateTime.Now;
                }
                else if (ctrl.HasChildren)
                {
                    ClearControls(ctrl);
                }
            }
        }

        private void Clear()
        {
            ClearControls(this);
        }

        private void ClearAll()
        {
            ClearControls(this);
            userDictionary.Clear();
        }

        private void PopulateGrid(string query, DataGridView grid, Label lblFeedback)
        {
            DataTable dataTable = MyAdo.GetDataTable(query);

            if (dataTable.Rows.Count == 0)
            {
                lblFeedback.Visible = true;
                grid.DataSource = null;
            }
            else
            {
                lblFeedback.Visible = false;
                grid.DataSource = dataTable;
                grid.Columns["RrecId"].Visible = false;
                grid.Columns["Read"].Visible = true;
                if (tabMain.SelectedTab.Text == "Sent")
                {
                    grid.Columns["Read"].Visible = false;
                }
            }

            grid.Refresh();
        }
        private void RefreshInbox()
        {
            Filter selectedFilter = (Filter)Enum.Parse(typeof(Filter), cmbFilter.SelectedValue.ToString());

            string query = $"SELECT FullName AS [Sender], Subject, Message, MessageDate, IsRead As [Read], RrecId " +
                           $"FROM MessagesV WHERE ToUser = {MyAdo.UserId}";

            switch (selectedFilter)
            {
                case Filter.Read:
                    query += " AND IsRead = 1";
                    break;
                case Filter.Unread:
                    query += " AND IsRead = 0";
                    break;
            }

            PopulateGrid(query, gridInbox, LblInboxFeedback);
        }
        private void RefreshSent()
        {
            string query = $"SELECT FullName [Recipient], Subject, Message, MessageDate, IsRead As [Read], RrecId " +
                           $"FROM MessagesSent WHERE FromUser = {MyAdo.UserId}";
            PopulateGrid(query, gridSent, LblSentFeedback);
        }
        private void UpdateSelectedMessagesReadStatus(bool isRead)
        {
            if (gridInbox.SelectedRows.Count == 0)
            {
                MessageBox.Show("No messages selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<int> messageIds = new List<int>();

            foreach (DataGridViewRow row in gridInbox.SelectedRows)
            {
                messageIds.Add(Convert.ToInt32(row.Cells["RrecId"].Value));
            }

            string query = $"UPDATE TbMessages SET IsRead = '{isRead}' WHERE RrecId IN ({string.Join(",", messageIds)})";
            MyAdo.Execute(query);

            MessageBox.Show($"Messages marked as {(isRead ? "Read" : "Unread")} successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshInbox();
        }
        private void SearchMessages(DateTime startDate, DateTime endDate, string subject, string senderOrRecipient, string query, DataGridView grid, Label lblFeedback)
        {
            if (!string.IsNullOrEmpty(subject))
            {
                query += $" AND Subject LIKE '%{subject}%'";
            }

            if (!string.IsNullOrEmpty(senderOrRecipient))
            {
                query += $" AND FullName LIKE '%{senderOrRecipient}%'";
            }

            query += $" AND MessageDate BETWEEN '{startDate:yyyy-MM-dd HH:mm:ss}' AND '{endDate:yyyy-MM-dd HH:mm:ss}'";

            PopulateGrid(query, grid, lblFeedback);
        }

        // Events
        private void FrmMain_Load(object sender, EventArgs e)
        {
            cmbFilter.DataSource = Enum.GetValues(typeof(Filter));
            cmbFilter.SelectedIndex = 0;
            ClearAll();

            string query = "SELECT UserID, FullName FROM Gusers ORDER BY FullName";
            DataTable dataTable = MyAdo.GetDataTable(query);

            foreach (DataRow row in dataTable.Rows)
            {
                int userId = Convert.ToInt32(row["UserID"]);
                if (userId == MyAdo.UserId)
                {
                    continue;
                }
                string userName = row["FullName"].ToString();
                Lst.Items.Add(userName);
                userDictionary[userId] = userName;
            }
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            string subject = TxtSubject.Text.Trim().Replace("'", "''");
            string message = TxtMessage.Text.Trim().Replace("'", "''");
            List<int> selectedUserIds = new List<int>();

            foreach (var selectedName in Lst.CheckedItems)
            {
                int userId = userDictionary.FirstOrDefault(x => x.Value == selectedName.ToString()).Key;

                if (userId != 0)
                {
                    selectedUserIds.Add(userId);
                }
            }

            if (selectedUserIds.Count > 0)
            {
                if (string.IsNullOrEmpty(subject))
                {
                    MessageBox.Show("Subject cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtSubject.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Message cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtMessage.Focus();
                    return;
                }

                string query = "INSERT INTO TbMessages (subject, message, FromUser, ToUser) VALUES";
                foreach (int toUser in selectedUserIds)
                {
                    query += $"('{subject}', '{message}', {MyAdo.UserId}, {toUser}),";
                }
                query = query.TrimEnd(',');
                MyAdo.Execute(query);
                MessageBox.Show("Message sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else
            {
                MessageBox.Show("No users selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ChkSelectAll.Checked;
            for (int i = 0; i < Lst.Items.Count; i++)
            {
                Lst.SetItemChecked(i, isChecked);
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();

            if (tabMain.SelectedTab.Text == "Inbox")
            {
                RefreshInbox();
            }
            else if (tabMain.SelectedTab.Text == "Sent")
            {
                RefreshSent();
            }
        }

        private void CmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshInbox();
        }

        private void BtnMarkAsRead_Click(object sender, EventArgs e)
        {
            UpdateSelectedMessagesReadStatus(true);
        }

        private void BtnMarkAsUnread_Click(object sender, EventArgs e)
        {
            UpdateSelectedMessagesReadStatus(false);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshInbox();
        }

        private void BtnSearchInbox_Click(object sender, EventArgs e)
        {
            DateTime startDate = DtpStartDateInbox.Value.Date;
            DateTime endDate = DtpEndDateInbox.Value.Date.AddDays(1).AddSeconds(-1);
            string subject = TxtSubjectSearchInbox.Text.Trim();
            string senderName = TxtSenderSearchInbox.Text.Trim();
            string baseQuery = $"SELECT FullName AS [Sender], Subject, Message, MessageDate, IsRead AS [Read], RrecId " +
                    $"FROM MessagesV WHERE ToUser = {MyAdo.UserId}";

            Filter selectedFilter = (Filter)Enum.Parse(typeof(Filter), cmbFilter.SelectedValue.ToString());
            switch (selectedFilter)
            {
                case Filter.Read:
                    baseQuery += " AND IsRead = 1";
                    break;
                case Filter.Unread:
                    baseQuery += " AND IsRead = 0";
                    break;
            }

            SearchMessages(startDate, endDate, subject, senderName, baseQuery, gridInbox, LblInboxFeedback);
        }

        private void BtnSearchSent_Click(object sender, EventArgs e)
        {
            DateTime startDate = DtpStartDateSent.Value.Date;
            DateTime endDate = DtpEndDateSent.Value.Date.AddDays(1).AddSeconds(-1);
            string subject = TxtSubjectSearchSent.Text.Trim();
            string RecipientName = TxtSenderSearchSent.Text.Trim();
            string baseQuery = $"SELECT FullName AS [Recipient], Subject, Message, MessageDate, IsRead As [Read], RrecId " +
                    $"FROM MessagesSent WHERE FromUser = {MyAdo.UserId}";
            SearchMessages(startDate, endDate, subject, RecipientName, baseQuery, gridSent, LblSentFeedback);
        }
    }
}
