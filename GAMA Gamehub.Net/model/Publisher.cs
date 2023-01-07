using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class Publisher
    {
        private int id;
        private string publisherName;

        public Publisher(int id, string publisherName)
        {
            this.Id = id;
            this.PublisherName = publisherName;
        }

        public int Id { get => id; set => id = value; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
    }
}
