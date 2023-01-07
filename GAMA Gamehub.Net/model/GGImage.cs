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
        private string image_path;

        public GGImage(int id, string image_path)
        {
            this.id = id;
            this.image_path = image_path;
        }

        public int Id { get => id; set => id = value; }
        public string Image_path { get => image_path; set => image_path = value; }
        
    }
}
