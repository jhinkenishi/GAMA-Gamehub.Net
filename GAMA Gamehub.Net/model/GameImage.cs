using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class GameImage
    {
        private int id, gameId, imageId;

        public GameImage( int gameId, int imageId)
        {
            this.GameId = gameId;
            this.ImageId = imageId;
        }
        public GameImage(int id, int gameId, int imageId)
        {
            this.Id = id;
            this.GameId = gameId;
            this.ImageId = imageId;
        }

        public int Id { get => id; set => id = value; }
        public int GameId { get => gameId; set => gameId = value; }
        public int ImageId { get => imageId; set => imageId = value; }
    }
}
