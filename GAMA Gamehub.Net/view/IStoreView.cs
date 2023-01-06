using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void SearchHandlerByProductId(int productId);
    public delegate void SearchHandlerByProductName(string productName);

    public interface IStoreView : ILibraryView
    {
        event SearchHandlerByProductId OnSearchByProductId;
        event SearchHandlerByProductName OnSearchByProductName;
    }
}
