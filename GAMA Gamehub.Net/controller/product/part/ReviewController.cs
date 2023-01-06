using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.product.part
{
    public abstract class ReviewController : ProductPartController
    {
        protected ReviewController(GGModel model, GGView view) : base(model, view)
        {

        }

        public abstract void Like();
        public abstract void Dislike();
        public abstract void Comment();
    }
}
