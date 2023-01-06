using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void RegisterHandler(string email, string username, string password);
    public delegate void LoginHandler(string username, string password);
    public delegate void LogoffHandler();
    public interface IAccountView : GGView
    {

        event RegisterHandler OnRegister;
        event RegisterHandler OnUnregister;
        event LoginHandler OnLogin;
        event LoginHandler OnLogoff;
    }
}
