using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.library
{
    public abstract class Cart
    {
        public const string COLUMN_USER_ID = "user_id";
        public const string COLUMN_PRODUCT_ID = "product_id";
        public abstract void Checkout();
    }
}
