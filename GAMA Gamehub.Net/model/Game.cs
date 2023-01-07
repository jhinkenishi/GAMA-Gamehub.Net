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
        private double rating;
        private double price;
        private int sold;


        public Game(int id, int genreId, string name, double rating, double price, int sold)
        {
            this.Id = id;
            this.GenreId = genreId;
            this.Name = name;
            this.rating = rating;
            this.price = price;
            this.sold = sold;
        }


        public int Id { get => id; set => id = value; }
        public int GenreId { get => genreId; set => genreId = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Sold { get => sold; set => sold = value; }
        public double Rating { get => rating; set => rating = value; }
    }
}
