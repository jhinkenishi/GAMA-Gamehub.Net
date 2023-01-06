using GAMA_Gamehub.database;
using GAMA_Gamehub.model.account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.test
{
    public class TestUser : Account
    {
        //This is just an example database
        Database db = Database.GetInstance();
        public override void Delete()
        {
            db.Connect();
            string query = "DELETE FROM " + TABLE_NAME +  " where user_id='" + COLUMN_USER_ID + "'";
            db.Query(query);
            db.Close();
        }

        public override void Insert()
        {
            db.Connect();
            string query = "INSERT INTO " + TABLE_NAME +" (" + COLUMN_USERNAME + ", " + COLUMN_PASSWORD + ") values (" + Get(COLUMN_USERNAME) + ", " + Get(COLUMN_PASSWORD) + ")";
            db.Query(query);
            db.Close();
        }

        public override void Login()
        {

        }

        public override void Logoff()
        {
        }

        public override void Register()
        {
            Insert();
        }

        public override void Select()
        {
        }

        public override void Unregister()
        {
        }

        public override void Update()
        {
            //DB UPDATE query 
        }
    }
}
