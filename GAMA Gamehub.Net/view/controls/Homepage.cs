using GAMA_Gamehub.view.controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMA_Gamehub.view.panel
{
    public partial class Homepage : UserControl
    {
        private Context context;
        public Homepage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

  


    }
}
