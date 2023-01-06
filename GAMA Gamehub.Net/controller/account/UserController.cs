using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.account
{
    public abstract class UserController : AccountController
    {

        public UserController(GGModel model, GGView view) : base(model, view)
        {
        }

    }
}
