using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net
{
    public class Game
    {
        private int id, genreId;
        private string name;

        public Game(int id, int genreId, string name)
        {
            this.Id = id;
            this.GenreId = genreId;
            this.Name = name;
        }

        public int Id { get => id; set => id = value; }
        public int GenreId { get => genreId; set => genreId = value; }
        public string Name { get => name; set => name = value; }
    }
}
