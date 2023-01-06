using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.product.part
{
    public abstract class ProductPartController : GGController
    {
        protected ProductPartController(GGModel model, GGView view) : base(model, view)
        {
        }
    }
}
