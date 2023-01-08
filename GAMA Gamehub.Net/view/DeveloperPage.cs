using GAMA_Gamehub.Net.model;
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
        private List<Game> games = new List<Game>();
        private List<GGImage> images = new List<GGImage>();
        private List<Genre> genres = new List<Genre>();
        private List<Description> descriptions = new List<Description>();

        private string fileName;
        private const string ROOT_FOLDER = "resource";
        private const string SUB_FOLDER = "images";
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

        public void AddImage(GGImage image)
        {
            MessageBox.Show(image.ImagePath);
            database.Query(String.Format("INSERT INTO image (image_path) VALUES ('{0}')", image.ImagePath));

        }
   

        public void AddDescription(Description description)
        {
            database.Query(string.Format("INSERT INTO description (message) VALUES ('{0}')", description.Message));
        }

        public void AddPublisher(Publisher publisher)
        {
            database.Query(string.Format("INSERT INTO publisher (publisher_name) VALUES ('{0}')", publisher.PublisherName));
        }
    

        private void btnUploadFile_Click_1(object sender, EventArgs e)
        {
            fileManager.ShowDialog();
        }

        private void OnFileOk(object sender, CancelEventArgs e)
        {
            string sourcePath = fileManager.FileName;

            string targetFolder = Path.Combine(Environment.CurrentDirectory, ROOT_FOLDER, SUB_FOLDER);

            if (!Directory.Exists(targetFolder))
            {
                Directory.CreateDirectory(targetFolder);
            }
            MessageBox.Show(targetFolder);
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
            int genreId = genres[cbGenres.SelectedIndex].Id;

            if (name == "" || publisher == "" || description == "" || price == 0 || context.GetStatus() == Context.LoginStatus.LOGOFF)
            {
               if(name == "")
                {
                    MessageBox.Show("No Name Specified");

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
                database.Query(String.Format("INSERT INTO game (genre_id, game_name, game_rating, game_price, game_sold) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", genreId, name, 1, price, 0));

                AddImage(new GGImage(ROOT_FOLDER +  "\\\\" + SUB_FOLDER+ "\\\\" + fileName));
                AddDescription(new Description(description));
                LoadRefresh();
                SetUpGameImage( new GameImage(games.Last().Id, images.Last().Id));
                SetUpGameDescription(new GameDescription(games.Last().Id, descriptions.Last().Id));


                //database.Query(String.Format("INSERT INTO product (name, publisher, price, description, imagePath) VALUES ('{0}', '{1}','{2}', '{3}', '{4}')", name, publisher, price, description, relativeImagePath + fileName));
                context.Controls.Clear();
                context.Controls.Add(new Homepage(context));
                lstBoxGamesPublished.Items.Clear();
                MessageBox.Show("You published a game.");
            }


            //database.Query(String.Format("INSERT INTO product_descriptions (description_id, product_id) VALUES ('{0}', '{1}','{2}')", name, publisher));

     

        }
        public void SetUpGameImage(GameImage gameImage)
        {
            database.Query(string.Format("INSERT INTO game_image (game_id, image_id) VALUES ('{0}', '{1}')", gameImage.GameId, gameImage.ImageId));
        }
        public void SetUpGameDescription(GameDescription gameDescription)
        {
            database.Query(string.Format("INSERT INTO game_description (game_id, description_id) VALUES ('{0}', '{1}')", gameDescription.GameId, gameDescription.DescriptionId));

        }


        private void Loader(object sender, EventArgs e)
        {
            LoadRefresh();
        }

        public void LoadRefresh()
        {
            //MySqlDataReader reader = database.QueryFirstRow(String.Format("SELECT name, publisher FROM product where publisher='{0}'", context.GetLogonUsername()));
            //lstBoxGamesPublished.Items.Clear();
            //while (reader.Read())
            //{
            //    lstBoxGamesPublished.Items.Add(reader[0].ToString());

            //}

            genres.Clear();
            MySqlDataReader reader = database.QueryFirstRow("SELECT * FROM genre");
            while (reader.Read())
            {
                cbGenres.Items.Add(reader.GetString(1));
                genres.Add(new Genre(reader.GetInt16(0), reader.GetString(1)));
            }
            cbGenres.SelectedIndex = 0;

            reader = database.QueryFirstRow("SELECT * FROM game");
            games.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int genreId = reader.GetInt32(1);
                string name = reader.GetString(2);
                double rating = reader.GetDouble(3);
                double price = reader.GetDouble(4);
                int sold = reader.GetInt32(5);
                games.Add(new Game(id, genreId, name, rating, price, sold));
            }

            reader = database.QueryFirstRow("SELECT * FROM description");
            descriptions.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string message = reader.GetString(1);
                descriptions.Add(new Description(id, message));
            }

            reader = database.QueryFirstRow("SELECT * FROM image");
            images.Clear();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string imagePath = reader.GetString(1);
                images.Add(new GGImage(id, imagePath));
            }



            reader.Close();
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
