using GAMA_Gamehub.controller.account;
using GAMA_Gamehub.model;
using GAMA_Gamehub.model.account;
using GAMA_Gamehub.view;
using GAMA_Gamehub.view.test;
using System.Drawing;

namespace GAMA_Gamehub.test
{
    public class TestUserController : AccountController
    {

        private User user;
        private IAccountView accountView;
        public TestUserController(GGModel model, GGView view) : base(model, view)
        {
            if (Model is User)
            {
                user = (User)Model;
            }
            if (View is IAccountView)
            {
                accountView = (IAccountView)View;
                accountView.OnLogin += LoginClicked;
                accountView.OnRegister += RegisterClicked;
            }
        }

        public override void Login()
        {
            if (Model is User)
            {
                User user = (User)Model;
                user.Login();
            }

        }

        public void LoginClicked(string username, string password)
        {
            user?.Set(Account.COLUMN_USERNAME, username);
            user?.Set(Account.COLUMN_PASSWORD, password);
            Login();
        }

        public void RegisterClicked(string email, string username, string password)
        {
            user?.Set(Account.COLUMN_EMAIL, email);
            user?.Set(Account.COLUMN_USERNAME, username);
            user?.Set(Account.COLUMN_PASSWORD, password);
            if (View is TestUserView)
            {
                TestUserView userPage = (TestUserView)View;
                userPage.BackColor =Color.Green;
            }
            Register();
        }

        public override void Logoff()
        {
            user?.Logoff();
        }

        public override void Register()
        {
            user?.Register();
        }

        public override void Unregister()
        {
            user?.Unregister();
        }
    }
}
