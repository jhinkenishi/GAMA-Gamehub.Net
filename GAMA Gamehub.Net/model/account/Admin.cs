using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.account
{
    public abstract class Admin : Account
    {
        public abstract void ManageDB();
    }
}
