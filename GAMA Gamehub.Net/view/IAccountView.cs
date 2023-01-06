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

        public event RegisterHandler? OnRegister;
        public event RegisterHandler? OnUnregister;
        public event LoginHandler? OnLogin;
        public event LoginHandler? OnLogoff;
    }
}
