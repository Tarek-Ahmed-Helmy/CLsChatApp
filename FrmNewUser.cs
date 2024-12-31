using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CLsChat
{
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || username.Length < 5 || username.Length > 20 || !Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$"))
            {
                MessageBox.Show("Username must be 5-20 characters long and contain only letters, numbers, or underscores.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(fullName) || fullName.Length < 3 || !Regex.IsMatch(fullName, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Full name must be at least 3 characters long and contain only letters and spaces.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFullName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$"))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(phone) && !Regex.IsMatch(phone, @"^01[0-2,5]\d{8}$"))
            {
                MessageBox.Show("Phone number must be an 11-digit Egyptian number starting with 01.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password) || password.Length < 8 || !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$"))
            {
                MessageBox.Show("Password must be at least 8 characters long and include uppercase, lowercase, a number, and a special character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmPassword.Focus();
                return;
            }

            string query = $"Select username from gusers where username='{username}'";
            string res = MyAdo.Search(query);
            if (res != null)
            {
                MessageBox.Show("Username already exist");
                txtUserName.Focus();
                return;
            }

            query = "INSERT INTO Gusers (UserName, FullName, Phone, Email, Password)";
            query += $"VALUES(N'{username}', N'{fullName}', '{phone}', '{email}', N'{password}')";
            int op = MyAdo.Execute(query);
            if (op == 1)
            {
                MessageBox.Show("User registerd successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is TextBox txt)
                    {
                        txt.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Server error, try again!", "Server Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
