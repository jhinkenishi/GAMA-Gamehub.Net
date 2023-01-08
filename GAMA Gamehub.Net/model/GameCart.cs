using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class GameCart
    {
        private int id;
        private string username;
        private int gameId;

        public GameCart( string username, int gameId)
        {
            this.username = username;
            this.gameId = gameId;
        }

        public GameCart(int id, string username, int gameId)
        {
            this.id = id;
            this.username = username;
            this.gameId = gameId;
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public int GameId { get => gameId; set => gameId = value; }
    }
}
