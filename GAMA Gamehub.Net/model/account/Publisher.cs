using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.account
{
    public abstract class Publisher
    {
        public const string COLUMN_STORE_ID = "store_id";

        public abstract void Publish();
    }
}
