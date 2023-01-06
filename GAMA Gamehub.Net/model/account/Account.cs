using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.account
{
    public abstract class Account : GGModel
    {
        public const string TABLE_NAME = "users";
        public const string COLUMN_USER_ID = "user_id";
        public const string COLUMN_NAME = "name";
        public const string COLUMN_EMAIL = "email";
        public const string COLUMN_USERNAME = "username";
        public const string COLUMN_PASSWORD = "password";
        public const string COLUMN_PHONE_NUMBER = "phone_number";
        public const string COLUMN_LOGIN_STATUS = "login_status";
        public const string COLUMN_USER_TYPE = "user_type";


        public abstract void Register();
        public abstract void Unregister();
        public abstract void Login();
        public abstract void Logoff();


    }
}
