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
        public Publisher(string publisherName)
        {
            this.publisherName = publisherName;
        }
        public Publisher(int id, string publisherName)
        {
            this.id = id;
            this.publisherName = publisherName;
        }

        public int Id { get => id; set => id = value; }
        public string PublisherName { get => publisherName; set => publisherName = value; }
    }
}
