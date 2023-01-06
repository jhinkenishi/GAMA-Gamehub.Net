using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.account
{
    public abstract class AccountController : GGController
    {
        protected AccountController(GGModel model, GGView view) : base(model, view)
        {
        }

        public abstract void Register();
        public abstract void Unregister();
        public abstract void Login();
        public abstract void Logoff();
    }
}
