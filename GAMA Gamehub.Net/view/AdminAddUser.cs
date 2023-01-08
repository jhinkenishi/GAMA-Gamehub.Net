using GAMA_Gamehub.Net.model;
using GAMA_Gamehub.Net.view.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GAMA_Gamehub.Net.view.controls
{
    public partial class AdminAddUser : UserControl
    {
        private GGDatabase database;
        public AdminAddUser()
        {
            database = GGDatabase.GetInstance();
            InitializeComponent();
            cbBoxUserType.Items.Add("basic");
            cbBoxUserType.Items.Add("developer");
            cbBoxUserType.Items.Add("admin");
            cbBoxUserType.SelectedIndex = 0;
        }
        public void AddUser(User user)
        {
            database.Query(String.Format("INSERT INTO users (name, email, username, password, login_status, user_type) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", user.Name, user.Email, user.Username, user.Password, user.LoginStatus, user.UserType));

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            string email = txtBoxEmail.Text;
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            string confirmPassword = txtBoxConPassword.Text;
            int loginStatus = ckboxLoginStatus.Checked ? 1 : 0;
            string userType = cbBoxUserType.Text.Equals("") ? "basic" : cbBoxUserType.SelectedText;

            if(ValidateAll(name, email, username, password, confirmPassword))
            {
                AddUser(new User(name, email, username, password, loginStatus, userType));
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("Check your inputs");
            }

            
        }
        public bool ValidateAll(string name, string email, string username, string password, string confirmPassword)
        {
            if( name.Equals("") || !ValidateUsername(username) || !ValidateEmail(email) || !ValidatePassword(password) || password != confirmPassword)
            {
                return false;
            }
            return true;
        }
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);

            if (!regex.IsMatch(email))
            {
                txtBoxEmail.BackColor = Color.Red;
                return false;
            }
            txtBoxEmail.BackColor = Color.White;
            return true;
        }

        public bool ValidateUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9_-]{3,15}$";

            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(username))
            {
                MessageBox.Show("Invalid Username");
                return false;
            }

            return true;
        }

        public bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(password))
            {
                return false;
            }
            return true;

     
            
        }

        private void OnEmailChange(object sender, EventArgs e)
        {
            string email = txtBoxEmail.Text;
            ValidateEmail(email);
        }

        private void OnPasswordChange(object sender, EventArgs e)
        {


        }
    }
}
