using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void ChooseTableHandler(string tableName);
    public delegate void QueryHandler(string query);
    public interface IAdminView : GGView
    {
        event ChooseTableHandler OnChooseTable;
        event QueryHandler OnQuery;
    }
}
