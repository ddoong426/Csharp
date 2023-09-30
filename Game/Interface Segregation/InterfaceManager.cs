using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface_Segregation
{
        interface Igun
        {
            public void Launch();

            public void Reload();
        }

        interface IScope
        {
            public void Zoom(float value);
        }
}
