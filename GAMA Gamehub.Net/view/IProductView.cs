using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void BuyNowHandler(int productId);
    public delegate void AddToCartHandler(int productId);
    public delegate void RemoveToCartHandler(int productId);
    public interface IProductView : GGView
    {
        event BuyNowHandler OnBuyNow;
        event AddToCartHandler OnAddToCart;
        event RemoveToCartHandler OnRemoveToCart;
    }
}
