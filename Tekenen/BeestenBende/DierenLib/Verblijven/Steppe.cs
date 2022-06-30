using DierenLib.Dieren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DierenLib.Verblijven
{
    public class Steppe: Verblijf
    {
        protected override bool Check(Dier d)
        {
            return d is Grazer;
        }
    }
}
