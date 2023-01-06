using GAMA_Gamehub.view.panel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMA_Gamehub.view.test
{
    public partial class TestUserView : UserControl, IAccountView
    {
        private Context context;
        public TestUserView(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        public event RegisterHandler OnRegister;
        public event RegisterHandler OnUnregister;
        public event LoginHandler OnLogin;
        public event LoginHandler OnLogoff;

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtboxEmail.Text;
            string username = txtBoxUsername.Text;
            string password = txtBoxPassword.Text;
            OnRegister?.Invoke(email, username, password);
            //context.Controls.Clear();
            //context.Controls.Add(new Homepage(context));


        }
    }
}
