using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.product.part
{
    public abstract class Image : ProductPart
    {
        public const string COLUMN_IMAGE_ID = "image_id";
        public const string COLUMN_NAME = "name";
        public const string COLUMN_PATH = "image_path";
        public const string COLUMN_PRODUCT_ID = "product_id";
        public abstract Bitmap GetBitmap();
    }
}
