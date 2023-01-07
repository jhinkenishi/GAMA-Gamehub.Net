using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class GGImage
    {
        private int id;
        private string imagePath;

        public GGImage(int id, string image_path)
        {
            this.id = id;
            this.imagePath = image_path;
        }

        public int Id { get => id; set => id = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        
    }
}
