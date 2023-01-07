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
    public partial class BuyNowPage : UserControl
    {
        private Context context;
        public BuyNowPage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }
    }
}
