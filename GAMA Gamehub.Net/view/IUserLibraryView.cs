using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void PlayHandler(string productId);
    public interface IUserLibraryView : ILibraryView
    {
        event PlayHandler OnPlay;
    }
}
