using GAMA_Gamehub.Net.view.controls;
using GAMA_Gamehub.Net.view.database;
using GAMA_Gamehub.view.panel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMA_Gamehub.view.controls
{
    public partial class LoginPage : UserControl
    {
        private Context context;
        private GGDatabase database;
        public LoginPage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            database = GGDatabase.GetInstance();
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new RegistrationPage(context));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            MySqlDataReader reader = database.QueryFirstRow("SELECT username, password FROM game_users where username='" + username + "'");
            bool isSuccessfulLogin = false;
            while (reader.Read())
            {
                string matchPassword = reader[1].ToString();
                if(password == matchPassword)
                {
                    MessageBox.Show("Successful");
                    context.Controls.Clear();
                    context.Controls.Add(new Homepage(context));
                    context.SetStatus(Context.LoginStatus.LOGON);
                    context.SetLogonUsername(username);
                    isSuccessfulLogin = true;
                }
  
            }
            if (!isSuccessfulLogin)
            {
                MessageBox.Show("Unsuccessful");
            }
    

        }
    }
}
