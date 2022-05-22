using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Interfaces
{
    internal interface ICommon
    {
        public void GetCut(Interfaces.ICut cut) { }

        public void GetCount(Interfaces.ICount count) { }
    }
}
