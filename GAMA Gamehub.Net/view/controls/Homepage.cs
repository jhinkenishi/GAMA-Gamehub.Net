using GAMA_Gamehub.Net.Properties;
using GAMA_Gamehub.Net.view;
using GAMA_Gamehub.Net.view.controls;
using GAMA_Gamehub.Net.view.database;
using GAMA_Gamehub.view.controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GAMA_Gamehub.view.panel
{
    public partial class Homepage : UserControl
    {
        private Context context;
        private GGDatabase database;
        private List<string> list = new List<string>();
        private List<string> productIDs = new List<string>();
        private List<string> titles = new List<string>();
        private List<string> prices = new List<string>();
        private List<string> descs = new List<string>();
        private List<string> imgs = new List<string>();
        private List<string> publishers = new List<string>();

        private List<string> dynamicPIDs = new List<string>();
        private List<string> dynamicTitles = new List<string>();
        private List<string> dynamicPrices = new List<string>();

        public Homepage(Context context)
        {
            database = GGDatabase.GetInstance();
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
            


        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if(context.GetStatus() == Context.LoginStatus.LOGOFF)
            {
                context.Controls.Clear();
                context.Controls.Add(new LoginPage(context));

            }
            else
            {
                btnAccount.Text = "Logout";
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new AdminPage(context));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new DeveloperPage(context));
        }

        private void load(object sender, EventArgs e)
        {

            MySqlDataReader reader = database.QueryFirstRow("SELECT product_id, name, price, description, image_path, publisher FROM product");
            while (reader.Read())
            {
                productIDs.Add(reader[0].ToString());
                titles.Add(reader[1].ToString());
                prices.Add(reader[2].ToString());
                list.Add(reader[1].ToString());
                descs.Add(reader[3].ToString());
                imgs.Add(reader[4].ToString());
                publishers.Add(reader[5].ToString());
            }
            foreach(string item in list)
            {
                listBoxGames.Items.Add(item);
            }

        }

        private void Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnTextChange(object sender, EventArgs e)
        {
            string search = searchbox.Text;
            listBoxGames.Items.Clear();
            dynamicPIDs.Clear();
            dynamicPrices.Clear();
            dynamicTitles.Clear();
            foreach (string item in list)
            {
                if (item.StartsWith(search, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxGames.Items.Add(item);
                }
            }


        }

        private void OnSelectedIndex(object sender, EventArgs e)
        {
            lblTitle.Text = titles[listBoxGames.SelectedIndex];
            lblDescription.Text = descs[listBoxGames.SelectedIndex];
            lblPublisher.Text = "Publish by: " + publishers[listBoxGames.SelectedIndex];
            lblPrice.Text = "Price: ₱" + prices[listBoxGames.SelectedIndex];
            try
            {
                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string imagePath = Path.Combine(baseDirectory, imgs[listBoxGames.SelectedIndex]);

                Image image = Image.FromFile(imagePath);
                gameImageBox.Image = image;
            }
            catch(Exception)
            {
                gameImageBox.Image = null;
            }
    
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new BuyNowPage(context));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new AddToCartPage(context));
        }

  
    }
}
