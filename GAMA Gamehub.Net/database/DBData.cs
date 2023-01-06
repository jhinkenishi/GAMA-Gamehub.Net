using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.database
{
    internal interface DBData
    {
        void Insert();
        void Delete();
        void Update();
        void Select();
    }
}
