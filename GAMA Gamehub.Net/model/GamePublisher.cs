using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class GamePublisher
    {
        private int id;
        private int gameId;
        private int publisherId;

        public GamePublisher(int id, int gameId, int publisherId)
        {
            this.id = id;
            this.gameId = gameId;
            this.publisherId = publisherId;
        }

        public int Id { get => id; set => id = value; }
        public int GameId { get => gameId; set => gameId = value; }
        public int PublisherId { get => publisherId; set => publisherId = value; }
    }
}
