using GAMA_Gamehub.Net.model;
using GAMA_Gamehub.Net.view.database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GAMA_Gamehub.Net.view.controls
{
    public partial class AdminEditGame : UserControl
    {
        private List<Game> games = new List<Game>();
        private List<GameDescription> gameDescriptions = new List<GameDescription>();
        private List<Description> descriptions = new List<Description>();
        private List<GamePublisher> gamePublishers = new List<GamePublisher>();
        private List<Publisher> publishers = new List<Publisher>();
        private List<GameImage> gameImages = new List<GameImage>();
        private List<GGImage> images = new List<GGImage>();
        private List<Genre> genres = new List<Genre>();
        private GGDatabase database = GGDatabase.GetInstance();
        private int publisherId = 0;
        private int descriptionId = 0;
        private int gameId = 0;
        private int imageId = 0;
        private const string ROOT_FOLDER = "resource";
        private const string SUB_FOLDER = "images";
        private string fileName;
        private int selectedGameIndex = 0;
        public AdminEditGame()
        {
            InitializeComponent();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtBoxSearch.Text;
            //foreach (string item in gameNames)
            //{
            //    if (item.StartsWith(search, StringComparison.CurrentCultureIgnoreCase))
            //    {
            //        listBoxGames.Items.Add(item);
            //    }
            //}
            cboxGames.Items.Clear();

            MySqlDataReader reader = database.QueryFirstRow(String.Format("SELECT * FROM game where game_name LIKE '{0}%' LIMIT 75", search));
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
                cboxGames.Items.Add(reader.GetString(2));
            }

            reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            selectedGameIndex = cboxGames.SelectedIndex;
            txtboxTitle.Text = games[selectedGameIndex].Name;
            numPrice.Value = (decimal)games[selectedGameIndex].Price;
            gameId = games[selectedGameIndex].Id;

            //
            string publisher = "";
            foreach (GamePublisher gp in gamePublishers)
            {
                if (gp.GameId.Equals(gameId))
                {
                    int publisherId = gp.PublisherId;
                    foreach (Publisher pb in publishers)
                    {
                        if (pb.Id.Equals(publisherId))
                        {
                            publisher = pb.PublisherName;


                        }
                    }
                }
            }
            txtBoxPublisher.Text =  publisher;
            //
            System.Drawing.Image image =pboxGameImage.ErrorImage;
            foreach (GameImage gi in gameImages)
            {
                if (gi.GameId.Equals(gameId))
                {
                    int gimageId = gi.ImageId;

                    foreach (GGImage gimage in images)
                    {
                        if (gimage.Id.Equals(gimageId))
                        {

                            try
                            {
                                string baseDirectory = Environment.CurrentDirectory;
                                string imagePath = Path.Combine(baseDirectory, gimage.ImagePath);
                                image = System.Drawing.Image.FromFile(imagePath);


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                        }

                    }
                }
            }

            pboxGameImage.Image = image;

            //
            string gameDescription = "No Description";
            foreach (GameDescription gd in gameDescriptions)
            {
                if (gd.GameId.Equals(gameId))
                {
                    int descriptionId = gd.DescriptionId;

                    foreach (Description desc in descriptions)
                    {
                        if (desc.Id.Equals(descriptionId))
                        {
                            gameDescription = desc.Message;

                        }

                    }
                }
            }
            txtboxDesc.Text = gameDescription;
            //if (games.Count > 0)
            //{
            //    int id = games[selectedIndex].Id;
            //    this.gameId = id;
            //    string title = games[selectedIndex].Name;
            //    int genreId = games[selectedIndex].GenreId;
            //    double price = games[selectedIndex].Price;
            //    string description = "No description";
            //    MessageBox.Show(string.Format("ID: {0}, TITLE: {1}, GENREID: {2}, PRICE: {3}, DESCRIPTION: {4}", id, title, genreId, price, description) );
            //    cboxGames.SelectedIndex = 0;
            //    cboxGenre.SelectedIndex = 0;
            //    foreach (GameDescription gd in gameDescriptions)
            //    {
            //        if (gd.GameId.Equals(id))
            //        {
            //            int descriptionId = gd.DescriptionId;

            //            foreach (Description desc in descriptions)
            //            {
            //                if (desc.Id.Equals(descriptionId))
            //                {
            //                    description = desc.Message;
            //                    this.descriptionId = desc.Id;
            //                }

            //            }
            //        }
            //    }

            //    cboxGenre.SelectedIndex = genreId - 1;


            //    string publisher = "No Publisher";
            //    foreach (GamePublisher gp in gamePublishers)
            //    {
            //        if (gp.GameId.Equals(id))
            //        {
            //            int publisherId = gp.PublisherId;
            //            foreach (Publisher pb in publishers)
            //            {

            //                if (pb.Id.Equals(publisherId))
            //                {
            //                    publisher = pb.PublisherName;
            //                    this.publisherId = pb.Id;

            //                }
            //            }
            //        }
            //    }

            //    System.Drawing.Image image = pboxGameImage.ErrorImage;
            //    foreach (GameImage gi in gameImages)
            //    {
            //        if (gi.GameId.Equals(id))
            //        {
            //            int gimageId = gi.ImageId;

            //            foreach (GGImage gimage in images)
            //            {
            //                if (gimage.Id.Equals(gimageId))
            //                {

            //                    try
            //                    {
            //                        string baseDirectory = Environment.CurrentDirectory;
            //                        string imagePath = Path.Combine(baseDirectory, gimage.ImagePath);
            //                        image = System.Drawing.Image.FromFile(imagePath);


            //                    }
            //                    catch (Exception ex)
            //                    {
            //                        MessageBox.Show(ex.Message);

            //                    }
            //                }

            //            }
            //        }
            //    }

            //    pboxGameImage.Image = image;
            //    txtboxTitle.Text = title;
            //    txtboxDesc.Text = description;
            //    txtBoxPublisher.Text = publisher;
            //    numPrice.Value = (decimal)price;


            //}
        }
        public void SetUpGameImage(GameImage gameImage)
        {
            database.Query(string.Format("INSERT INTO game_image (game_id, image_id) VALUES ('{0}', '{1}')", gameImage.GameId, gameImage.ImageId));
        }
        public void SetUpGameDescription(GameDescription gameDescription)
        {
            database.Query(string.Format("INSERT INTO game_description (game_id, description_id) VALUES ('{0}', '{1}')", gameDescription.GameId, gameDescription.DescriptionId));

        }

        public void LoadRefresh()
        {
            MySqlDataReader reader = database.QueryFirstRow(string.Format("SELECT * FROM game LIMIT 10"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int genreId = reader.GetInt32(1);
                string gameName = reader.GetString(2);
                double rating = reader.GetDouble(3);
                double price = reader.GetDouble(4);
                int sold = reader.GetInt32(5);
                games.Add(new Game(id, genreId, gameName, rating, price, sold));
            }
            reader.Close();


            reader = database.QueryFirstRow(string.Format("SELECT * FROM genre"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                genres.Add(new Genre(id, name));
            }
            reader = database.QueryFirstRow(string.Format("SELECT * FROM game_description"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int gameId = reader.GetInt32(1);
                int descriptionId = reader.GetInt32(2);
                gameDescriptions.Add(new GameDescription(id, gameId, descriptionId));
            }
            reader = database.QueryFirstRow(string.Format("SELECT * FROM description"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string message = reader.GetString(1);
                descriptions.Add(new Description(id, message));
            }
            reader.Close();
            reader = database.QueryFirstRow(string.Format("SELECT * FROM game_publisher"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int gameId = reader.GetInt32(1);
                int publisherId = reader.GetInt32(2);
                gamePublishers.Add(new GamePublisher(id, gameId, publisherId));
            }

            reader = database.QueryFirstRow(string.Format("SELECT * FROM publisher"));
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string publisherName = reader.GetString(1);
                publishers.Add(new Publisher(id, publisherName));
            }
            reader.Close();

            reader = database.QueryFirstRow("SELECT * FROM image");
            images.Clear();
            while (reader.Read())
            {
                images.Add(new GGImage(int.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            //reader.Close();
            reader.Close();

            reader = database.QueryFirstRow("SELECT * FROM game_image");
            gameImages.Clear();

            while (reader.Read())
            {
                gameImages.Add(new GameImage(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), int.Parse(reader[2].ToString())));
            }
            reader.Close();



            foreach (Game game in games)
            {
                cboxGames.Items.Add(game.Name);
            }
            foreach (Genre genre in genres)
            {
                cboxGenre.Items.Add(genre.Name);
            }

            if (games.Count > 0)
            {
                int id = games[selectedGameIndex].Id;
                string title = games[selectedGameIndex].Name;
                int genreId = games[selectedGameIndex].GenreId;
                double price = games[selectedGameIndex].Price;
                string description = "No description";
                cboxGames.SelectedIndex = selectedGameIndex;
                cboxGenre.SelectedIndex = 0;
                foreach (GameDescription gd in gameDescriptions)
                {
                    if (gd.GameId.Equals(id))
                    {
                        int descriptionId = gd.DescriptionId;

                        foreach (Description desc in descriptions)
                        {
                            if (desc.Id.Equals(descriptionId))
                            {
                                description = desc.Message;
                                this.descriptionId = desc.Id;
                            }

                        }
                    }
                }
                cboxGenre.SelectedIndex = genreId - 1;

                string publisher = "No Publisher";
                foreach (GamePublisher gp in gamePublishers)
                {
                    if (gp.GameId.Equals(id))
                    {
                        int publisherId = gp.PublisherId;
                        foreach (Publisher pb in publishers)
                        {
                            if (pb.Id.Equals(publisherId))
                            {
                                publisher = pb.PublisherName;
                                this.publisherId = pb.Id;

                            }
                        }
                    }
                }

                System.Drawing.Image image = pboxGameImage.ErrorImage;
                foreach (GameImage gi in gameImages)
                {
                    if (gi.GameId.Equals(id))
                    {
                        int gimageId = gi.ImageId;
                        foreach (GGImage gimage in images)
                        {
                            if (gimage.Id.Equals(gimageId))
                            {
                                this.imageId = gimage.Id;

                                try
                                {
                                    string baseDirectory = Environment.CurrentDirectory;
                                    string imagePath = Path.Combine(baseDirectory, gimage.ImagePath);
                                    image = System.Drawing.Image.FromFile(imagePath);


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                }
                            }

                        }
                    }
                }

                pboxGameImage.Image = image;
                txtboxTitle.Text = title;
                txtboxDesc.Text = description;
                txtBoxPublisher.Text = publisher;
                numPrice.Value = (decimal)price;


            }
        }

        public void AddDescription(Description description)
        {
            database.Query(string.Format("INSERT INTO description (message) VALUES ('{0}')", description.Message));
        }

        public void AddPublisher(Publisher publisher)
        {
            database.Query(string.Format("INSERT INTO publisher (publisher_name) VALUES ('{0}')", publisher.PublisherName));
        }

        public void AddImage(GGImage image)
        {
            MessageBox.Show(image.ImagePath);
            database.Query(String.Format("INSERT INTO image (image_path) VALUES ('{0}')", image.ImagePath));

        }



        private void pboxGameImage_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            gameImageFileDirectory.ShowDialog();
        }

        private void lblGameTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtboxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cboxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void txtBoxPublisher_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetupGamePublisher(GamePublisher gamePublisher)
        {
            database.Query(string.Format("INSERT INTO game_publisher (game_id, publisher_id) VALUES ('{0}', '{1}')", gamePublisher.GameId, gamePublisher.PublisherId));
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            string title = txtboxTitle.Text;
            string desc = txtboxDesc.Text;
            string publisher = txtBoxPublisher.Text;
            double price = (double)numPrice.Value;
            int genreId = cboxGenre.SelectedIndex;

            bool hasDescription = false;
            bool hasPublisher = false;
            bool hasImage = false;
            string imageFilePath = ROOT_FOLDER + "\\\\" + SUB_FOLDER + "\\\\" + fileName;

            foreach (GameDescription gd in gameDescriptions)
            {
                if (gd.Id.Equals(descriptionId))
                {
                    hasDescription = true;
                }
            }
            foreach(GamePublisher gd in gamePublishers)
            {
                if (gd.Id.Equals(publisherId))
                {
                    hasPublisher = true;
                }
            }
            foreach(GameImage ggimage in gameImages)
            {
                if (ggimage.ImageId.Equals(imageId))
                {
                    hasImage = true;
                }
            }

            if (hasPublisher)
            {
                database.Query(string.Format("UPDATE publisher SET publisher_name='{0}' WHERE id='{1}'", publisher, publisherId));
                MessageBox.Show("Update Publisher");
            }
            else
            {
                AddPublisher(new Publisher(publisher));
                LoadRefresh();
                SetupGamePublisher(new GamePublisher(gam, publishers.Last().Id));
                MessageBox.Show("Added Publisher");
            }
            if (hasDescription)
            {
                database.Query(string.Format("UPDATE description SET message='{0}' WHERE id='{1}'", desc, descriptionId));
                MessageBox.Show("Update Description");
            }
            else
            {
                AddDescription(new Description(desc));
                LoadRefresh();
                SetUpGameDescription(new GameDescription(games.Last().Id, descriptions.Last().Id));
                MessageBox.Show("Added Description");
            }
            if (hasImage)
            {
                database.Query(string.Format("UPDATE image SET image_path='{0}' WHERE id='{1}'", imageFilePath, imageId));
                MessageBox.Show("Update Image");
            }
            else
            {
                AddImage(new GGImage(imageFilePath));
                LoadRefresh();
                SetUpGameImage(new GameImage(games.Last().Id, images.Last().Id));
                MessageBox.Show("Added Image");
            }

            database.Query(string.Format("UPDATE game SET genre_id ='{0}', game_name ='{1}',game_price ='{2}' WHERE id = '{3}'", genreId, title, price, gameId));


            
        }


        private void AdminEditGame_Load(object sender, EventArgs e)
        {
            LoadRefresh();

        }

        private void FileOk(object sender, CancelEventArgs e)
        {
            string sourcePath = gameImageFileDirectory.FileName;

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
            pboxGameImage.Image = image;
        }
    }
}
