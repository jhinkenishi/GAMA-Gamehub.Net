using GAMA_Gamehub.model.product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.model.library
{
    public abstract class Library : GGModel
    {
        protected List<Product> productList = new List<Product>();

    }
}
