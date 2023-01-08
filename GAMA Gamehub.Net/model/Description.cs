using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.Net.model
{
    public class Description
    {
        private int id;
        private string message;

        public Description(string message)
        {
            this.message = message;
        }

        public Description(int id, string message)
        {
            this.id = id;
            this.message = message;

        }


        public int Id { get => id; set => id = value; }
        public string Message { get => message; set => message = value; }

    }
}
