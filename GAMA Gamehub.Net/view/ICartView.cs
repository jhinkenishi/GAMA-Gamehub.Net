using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void CheckoutHandler(string userId);
    public interface ICartView : ILibraryView
    {
        event CheckoutHandler? OnCheckout;
    }
}
