﻿using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.controller.library
{
    public abstract class CartController : LibraryController
    {
        public CartController(GGModel model, GGView view) : base(model, view)
        {
        }

        public abstract void Checkout();



    }
}
