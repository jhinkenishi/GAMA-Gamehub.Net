using GAMA_Gamehub.Net.view.database;
using GAMA_Gamehub.view.panel;
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

namespace GAMA_Gamehub.view.controls
{
    public partial class RegistrationPage : UserControl
    {
        private Context context;
        private GGDatabase database;
        public RegistrationPage(Context context)
        {
            database = GGDatabase.GetInstance();
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text;
            string username = txtboxUsername.Text;
            string password = txtboxPassword.Text;
            string confirmPassword = txtBoxConPass.Text;

            if (ValidateEmail(email) || ValidateUsername(username) || ValidatePassword(password) || password == confirmPassword)
            {
                database.Query(String.Format("INSERT INTO users (email, username, password, login_status, user_type) VALUES ('{0}', '{1}','{2}', '{3}', '{4}')", email, username, password, 1, "basic"));

                context.Controls.Clear();
                context.Controls.Add(new Homepage(context));
                context.SetStatus(Context.LoginStatus.LOGON);
                context.SetLogonUsername(username);
            }
            else
            {
                MessageBox.Show("Invalid!");
            }

        }
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        public bool ValidateUsername(string username)
        {
            string pattern = @"^[a-zA-Z0-9_-]{3,15}$";

            Regex regex = new Regex(pattern);

            return regex.IsMatch(username);
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

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }
    }
}
