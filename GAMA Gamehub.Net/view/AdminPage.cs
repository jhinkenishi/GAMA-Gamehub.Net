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
    public partial class AdminPage : UserControl
    {
        private Context context;
        public AdminPage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminAddUser());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminAddProduct());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminEditUser());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminEditGame());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminDeleteUser());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            managePanel.Controls.Clear();
            managePanel.Controls.Add(new AdminDeleteProduct());
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }
    }
}
