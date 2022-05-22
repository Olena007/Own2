using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier.Services
{
    internal class Common : Interfaces.ICommon
    {
        public void GetCut(Interfaces.ICut cut)
        {
            cut.Cut();
        }

        public void GetCount(Interfaces.ICount count)
        {
            var array = new Models.EnterArray();

            count.Count(array.array);
        }
    }
}
