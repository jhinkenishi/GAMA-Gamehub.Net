using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void ShowDescriptionHandler(int descriptionId, int productId);
    public delegate void ShowDescriptionsHandler(int productId);
    public interface IDescriptionView : GGView
    {
        event ShowDescriptionHandler OnShowDescription;
        event ShowDescriptionsHandler OnShowDescriptions;


    }
}
