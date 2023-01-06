using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMA_Gamehub.database;

namespace GAMA_Gamehub.model
{
    public abstract class GGModel : DBData
    {
        protected Dictionary<string, object> attributes = new Dictionary<string, object>();

        public void Set(string key, object value)
        {
            attributes[key] = value;
        }
        public object Get(string key)
        {
            return attributes[key];
        }

        public abstract void Insert();
        public abstract void Delete();
        public abstract void Update();
        public abstract void Select();
    }
}
