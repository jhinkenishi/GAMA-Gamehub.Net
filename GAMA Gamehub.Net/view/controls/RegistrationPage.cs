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

            if (!ValidateEmail(email) || !ValidateUsername(username) || IsPasswordValid(password))
            {
                MessageBox.Show("Invalid!" );
            }
            else
            {
                database.Query(String.Format("INSERT INTO users (email, username, password, login_status, user_type) VALUES ('{0}', '{1}','{2}', '{3}', '{4}')", email, username, password, 1, "basic"));

                context.Controls.Clear();
                context.Controls.Add(new Homepage(context));
                context.SetStatus(Context.LoginStatus.LOGON);
                context.SetLogonUsername(username);
            }

        }
        public bool ValidateEmail(string email)
        {
            // Define the regular expression pattern
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Create a new Regex object
            Regex regex = new Regex(pattern);

            // Check if the email address matches the pattern
            return regex.IsMatch(email);
        }
        public bool ValidateUsername(string username)
        {
            // Define the regular expression pattern
            string pattern = @"^[a-zA-Z0-9_-]{3,15}$";

            // Create a new Regex object
            Regex regex = new Regex(pattern);

            // Check if the username matches the pattern
            return regex.IsMatch(username);
        }
        public bool ValidatePassword(string password, out string ErrorMessage)
        {
            string input = password;
            ErrorMessage = string.Empty;

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Password should not be empty");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one lower case letter";
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one upper case letter";
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                ErrorMessage = "Password should not be less than or greater than 12 characters";
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one numeric value";
                return false;
            }

            else if (!hasSymbols.IsMatch(input))
            {
                ErrorMessage = "Password should contain At least one special case characters";
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool IsPasswordValid(string password)
        {
            // Check if the password is at least 8 characters long
            if (password.Length < 8)
            {
                return false;
            }

            // Check if the password contains at least one lowercase letter
            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return false;
            }

            // Check if the password contains at least one uppercase letter
            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return false;
            }

            // Check if the password contains at least one digit
            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return false;
            }

            // Check if the password contains at least one special character
            if (!Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                return false;
            }

            // If all checks pass, the password is valid
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }
    }
}
