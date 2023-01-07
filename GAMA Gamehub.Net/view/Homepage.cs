using GAMA_Gamehub.Net;
using GAMA_Gamehub.Net.model;
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
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GAMA_Gamehub.view.panel
{
    public partial class Homepage : UserControl
    {
        private Context context;
        private GGDatabase database;
        private List<string> gameNames = new List<string>();
        private List<Game> games = new List<Game>();
        private List<GameImage> gameImages = new List<GameImage>();
        private List<GamePublisher> gamePublishers = new List<GamePublisher>();
        private List<GGImage> images = new List<GGImage>();
        private List<Publisher> publishers = new List<Publisher>();

        private int selectedIndex  = 0;


        public Homepage(Context context)
        {
            database = GGDatabase.GetInstance();
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
            if (context.GetStatus() == Context.LoginStatus.LOGON)
            {
                btnAccount.Text = "View your Account";
            }


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
                context.Controls.Clear();
                context.Controls.Add(new AccountPage(context));
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

            MySqlDataReader reader = database.QueryFirstRow("SELECT * FROM game");
            while (reader.Read())
            {
                games.Add(new Game(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), reader[2].ToString()));
                gameNames.Add(reader[2].ToString());
            }

            //reader.Close();


            reader = database.QueryFirstRow("SELECT * FROM publisher");
            while (reader.Read())
            {
                publishers.Add(new Publisher(int.Parse(reader[0].ToString()), reader[1].ToString()));
            }
           // reader.Close();

            reader = database.QueryFirstRow("SELECT * FROM image");

            while (reader.Read())
            {
                images.Add(new GGImage(int.Parse(reader[0].ToString()), reader[1].ToString()));
            }
            //reader.Close();

            reader = database.QueryFirstRow("SELECT * FROM game_image");
            while (reader.Read())
            {
                gameImages.Add(new GameImage(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), int.Parse(reader[2].ToString())));
            }

            reader = database.QueryFirstRow("SELECT * FROM game_publisher");
            while (reader.Read())
            {
                gamePublishers.Add(new GamePublisher(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), int.Parse(reader[2].ToString())));

            }

            foreach (string item in gameNames)
            {
                listBoxGames.Items.Add(item);
            }
            MessageBox.Show("Finish loading");
            reader.Close();
            

        }

        private void Paint(object sender, PaintEventArgs e)
        {

        }

        private void OnTextChange(object sender, EventArgs e)
        {
            string search = searchbox.Text;
            listBoxGames.Items.Clear();
            foreach (string item in gameNames)
            {
                if (item.StartsWith(search, StringComparison.CurrentCultureIgnoreCase))
                {
                    listBoxGames.Items.Add(item);
                }
            }


        }

        private void OnSelectedIndex(object sender, EventArgs e)
        {
            selectedIndex = listBoxGames.SelectedIndex;
            lblTitle.Text = gameNames[selectedIndex];

            int selectedGameId = games[selectedIndex].Id;

            //
            foreach(GamePublisher gp in gamePublishers)
            {
                if (gp.GameId.Equals(selectedGameId))
                {
                    int publisherId = gp.PublisherId;
                    foreach(Publisher pb in publishers)
                    {
                        if (pb.Id.Equals(publisherId))
                        {
                            lblPublisher.Text = "Published by: " + pb.PublisherName;
                        }
                    }
                }
            }
            //
            foreach (GameImage gi in gameImages)
            {
                if (gi.GameId.Equals(selectedGameId))
                {
                    int gameId = gi.GameId;
                    foreach (GGImage gimage in images)
                    {
                        if (gimage.Id.Equals(gameId))
                        {

                            try
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
          
                                string imagePath = Path.Combine(baseDirectory, gimage.Image_path);

                                System.Drawing.Image image = System.Drawing.Image.FromFile(imagePath);
                                gameImageBox.Image = image;
                            }
                            catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                       
                        

                    }
                }
            }



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(context.GetStatus() == Context.LoginStatus.LOGON)
            {
                context.Controls.Clear();
                context.Controls.Add(new BuyNowPage(context));
            }
            else
            {
                context.Controls.Clear();
                context.Controls.Add(new LoginPage(context));
            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (context.GetStatus() == Context.LoginStatus.LOGON)
            {
                context.Controls.Clear();
                context.Controls.Add(new AddToCartPage(context));

            }
            else
            {
                context.Controls.Clear();
                context.Controls.Add(new LoginPage(context));
            }
            
        }

  
    }
}
