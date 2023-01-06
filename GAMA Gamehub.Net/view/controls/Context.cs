using GAMA_Gamehub.view;
using GAMA_Gamehub.view.panel;
using GAMA_Gamehub.view.test;

namespace GAMA_Gamehub
{
    
    public partial class Context : Form
    {
        private Control view;
        public Context()
        {
            view = new TestUserView(this);
            SetCurrentView(view);
            Controls.Add(view);
            InitializeComponent();
        }

        public void SetCurrentView(Control view)
        {
            this.view = view;
        }
        public GGView GetCurrentView()
        {
            if(view is GGView)
            {
                return (GGView)view;
            }
            return new EmptyView();
        }
    }


}