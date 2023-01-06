using GAMA_Gamehub.controller.library;
using GAMA_Gamehub.model;
using GAMA_Gamehub.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.test
{
    internal class TestUserLibraryController : UserLibraryController
    {
        public TestUserLibraryController(GGModel model, GGView view) : base(model, view)
        {
        }

        public override void Delete()
        {

        }

        public override void Insert()
        {

        }

        public override void Play()
        {
        }

        public override void Select()
        {
            //Select
        }

        public override void Update()
        {

        }
    }
}
