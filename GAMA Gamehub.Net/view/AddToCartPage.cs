using GAMA_Gamehub.Net.model;
using GAMA_Gamehub.Net.view.database;
using GAMA_Gamehub.view.panel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMA_Gamehub.Net.view
{
    public partial class AddToCartPage : UserControl
    {
        private Context context;
        private GGDatabase database;
        private List<Game> games = new List<Game>();
        private List<GameCart> gameCarts = new List<GameCart>();

        public AddToCartPage(Context context)
        {
            database = GGDatabase.GetInstance();
            Dock = DockStyle.Fill;
            this.context = context;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context.Controls.Clear();
            context.Controls.Add(new Homepage(context));
        }

        private void OnLoad(object sender, EventArgs e)
        {
            MySqlDataReader reader = database.QueryFirstRow(string.Format("SELECT * FROM game_cart where username='{0}'", context.GetLogonUsername()));

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string username = reader.GetString(1);
                int gameId = reader.GetInt32(2);
                gameCarts.Add(new GameCart(id, username, gameId));

            }
            reader = database.QueryFirstRow("SELECT * FROM game");
            while (reader.Read())
            {
                
                int id = reader.GetInt32(0);
                int genre = reader.GetInt32(1);
                string name = reader.GetString(2);
                double rating = reader.GetDouble(3);
                double price = reader.GetDouble(4);
                int sold = reader.GetInt32(5);
                games.Add(new Game(id, genre, name, rating, price, sold));
            }
            double totalPrice = 0;
            foreach (GameCart cart in gameCarts)
            {
                int gameId = cart.GameId;
                foreach (Game game in games)
                {
                    if (game.Id.Equals(gameId))
                    {
                        totalPrice += game.Price;
                        lstBoxGame.Items.Add(game.Name);
                        rchDetails.AppendText(" + $" + game.Price + "\n");
                    }
                }
            }
            rchDetails.AppendText("--------------------------");
            rchDetails.AppendText("------Total:$" + totalPrice);
            lblTotal.Text = "Total: $" + totalPrice;


            reader.Close();
      
        }
    }
}
