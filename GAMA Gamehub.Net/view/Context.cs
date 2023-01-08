using GAMA_Gamehub.view;
using GAMA_Gamehub.view.controls;
using GAMA_Gamehub.view.panel;
using System.Windows.Forms;

namespace GAMA_Gamehub
{
    
    public partial class Context : Form
    {
        private Control view;
        private LoginStatus status = LoginStatus.LOGOFF;
        private string logUsername;
        private int currentSelectedGame;

        public int CurrentSelectedGame { get => currentSelectedGame; set => currentSelectedGame = value; }

        public Context()
        {
            view = new Homepage(this);
            Controls.Add(view);
            InitializeComponent();
        }

        public void SetStatus(LoginStatus status)
        {
            this.status = status;
        }
        public string GetLogonUsername()
        {
            return this.logUsername;
        }
        public void SetLogonUsername(string username)
        {
            this.logUsername = username;
        }
        public LoginStatus GetStatus()
        {
            return this.status;
        }
        public enum LoginStatus{
            LOGON,
            LOGOFF,
        }

    }


}