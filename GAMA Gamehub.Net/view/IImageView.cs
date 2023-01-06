using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void ShowImageHandler(int imageId, int productId);
    public delegate void ShowImagesHandler(int productId);
    public interface IImageView :GGView
    {
        event ShowImageHandler OnShowImage;
        event ShowImagesHandler OnShowImages;
    }
}
