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

namespace GAMA_Gamehub.Net.view.controls
{
    public partial class AccountPage : UserControl
    {
        private Context context;
        public AccountPage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        private void Loader(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            context.SetStatus(Context.LoginStatus.LOGOFF);
            context.SetLogonUsername("");
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }
    }
}
