using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller
{
    public abstract class GGController
    {
        private GGModel model;
        private GGView view;

        protected GGModel Model { get => model; set => model = value; }
        protected GGView View { get => view; set => view = value; }

        protected GGController(GGModel model, GGView view)
        {
            this.Model = model;
            this.View = view;
        }



    }
}
