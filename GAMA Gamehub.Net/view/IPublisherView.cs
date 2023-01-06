using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void PublishHandler(int storeId, string productName, string publisherId, double price);
    public interface IPublisherView : GGView
    {
        event PublishHandler OnPublish;

    }
}
