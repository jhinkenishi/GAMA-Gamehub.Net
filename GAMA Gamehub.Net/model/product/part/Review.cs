using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.product.part
{
    public abstract class Review : ProductPart
    {
        public const string COLUMN_REVIEW_ID = "review_id";
        public const string COLUMN_NAME = "name";
        public const string COLUMN_USER_ID = "user_id";
        public const string COLUMN_USER_NAME = "name";
        public const string COLUMN_PRODUCT_ID = "product_id";
        public const string COLUMN_RECOMMENDED = "recommended";

        public abstract void Like();
        public abstract void Dislike();
        public abstract void Comment();

    }
}
