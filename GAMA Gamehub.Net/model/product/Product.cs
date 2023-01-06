using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.product
{
    public abstract class Product : GGModel
    {
        public const string COLUMN_PRODUCT_ID = "product_id";
        public const string COLUMN_PRODUCT_NAME = "name";
        public const string COLUMN_PUBLISHER_NAME = "publisher_name";
        public const string COLUMN_RATING = "rating";
        public const string COLUMN_PRICE = "price";
        public const string COLUMN_SOLD = "sold";

        public abstract void BuyNow();
        public abstract void AddToCart();
        public abstract void RemoveToCart();




    }
}
