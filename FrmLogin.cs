using System;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            MyAdo.Begin();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            string query = $"SELECT userid FROM Gusers WHERE UserName = '{username}' and Password = '{password}'";
            string res = MyAdo.Search(query);

            if (res == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MyAdo.UserId = int.Parse(res);
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();

            frmMain.FormClosed += (s, args) => Application.Exit();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FrmNewUser frmNewUser = new FrmNewUser();
            frmNewUser.ShowDialog();
        }
    }
}
