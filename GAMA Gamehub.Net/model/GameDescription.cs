using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class GameDescription
    {
        private int id;
        private int gameId;
        private int descriptionId;

        public GameDescription(int gameId, int descriptionId)
        {
            this.gameId = gameId;
            this.descriptionId = descriptionId;
        }


        public GameDescription(int id, int gameId, int descriptionId)
        {
            this.id = id;
            this.gameId = gameId;
            this.descriptionId = descriptionId;
        }

        public int Id { get => id; set => id = value; }
        public int GameId { get => gameId; set => gameId = value; }
        public int DescriptionId { get => descriptionId; set => descriptionId = value; }
    }
}
