using GAMA_Gamehub.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAMA_Gamehub.Net
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Context context = new Context();
            TestUserController controller = new TestUserController(new TestUser(), context.GetCurrentView());
            Application.Run(context);

        }
    }
}
