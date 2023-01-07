using GAMA_Gamehub.Net.Properties;
using GAMA_Gamehub.Net.view.database;
using GAMA_Gamehub.view.panel;
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
using static System.Net.Mime.MediaTypeNames;

namespace GAMA_Gamehub.Net.view.controls
{
    public partial class DeveloperPage : UserControl
    {
        private Context context;
        private GGDatabase database;
        private List<string> filepaths = new List<string>();
        private string relativeImagePath = "resource/images/";
        private string fileName;
        private List<string> publishedGames = new List<string>();
        public DeveloperPage(Context context)
        {
            Dock = DockStyle.Fill;
            this.context = context;
            database = GGDatabase.GetInstance();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }

    

        private void btnUploadFile_Click_1(object sender, EventArgs e)
        {
            fileManager.ShowDialog();
        }

        private void OnFileOk(object sender, CancelEventArgs e)
        {
            string sourcePath = fileManager.FileName;

            string rootFolder = "resource";
            string subFolder = "images";

            string targetFolder = Path.Combine(Environment.CurrentDirectory, rootFolder, subFolder);

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }

            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            fileName = $"image_{timestamp}.jpg";
            string targetPath = Path.Combine(targetFolder, fileName);

            try
            {
                File.Copy(sourcePath, targetPath, true);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }

            System.Drawing.Image image = System.Drawing.Image.FromFile(sourcePath);
            gamePic.Image = image;

        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string name = txtBoxTitle.Text;
            string publisher = context.GetLogonUsername();
            string description = txtboxDesc.Text;
            double price = (double)inptPrice.Value;
            if (name == "" || publisher == "" || description == "" || price == 0 || context.GetStatus() == Context.LoginStatus.LOGOFF)
            {
               if(name == "")
                {
                    MessageBox.Show("No Image Specified");
                }else if(publisher == "")
                {
                    MessageBox.Show("You are not login!");
                }else if(description == "")
                {
                    MessageBox.Show("No Description");
                }else if(price == 0)
                {
                    MessageBox.Show("Price is not set!");
                }else if(context.GetStatus() == Context.LoginStatus.LOGOFF)
                {
                    MessageBox.Show("You are not login!");
                }
            }
            else
            {
                database.Query(String.Format("INSERT INTO game (game_name) VALUES ('{0}')", name));
                //database.Query(String.Format("INSERT INTO product (name, publisher, price, description, image_path) VALUES ('{0}', '{1}','{2}', '{3}', '{4}')", name, publisher, price, description, relativeImagePath + fileName));
                context.Controls.Clear();
                context.Controls.Add(new Homepage(context));
                lstBoxGamesPublished.Items.Clear();
            }


            //database.Query(String.Format("INSERT INTO product_descriptions (description_id, product_id) VALUES ('{0}', '{1}','{2}')", name, publisher));

     

        }
    

        private void Loader(object sender, EventArgs e)
        {
            MySqlDataReader reader = database.QueryFirstRow(String.Format("SELECT name, publisher FROM product where publisher='{0}'", context.GetLogonUsername()));
            while (reader.Read())
            {
                lstBoxGamesPublished.Items.Add(reader[0].ToString());
            }

        }

        private void MouseDonw(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                DialogResult result = MessageBox.Show("Edit Mode?", "Confirm", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    MessageBox.Show("Haha!, You'got prnked");
                }
                else
                {
                    MessageBox.Show("Huh!, You don't wnna see");
                }
            }
        }
    }
}
