using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.product.part
{
    public abstract class ImageController : ProductPartController
    {
        protected ImageController(GGModel model, GGView view) : base(model, view)
        {
        }

        public abstract Bitmap GetImage();
    }
}
