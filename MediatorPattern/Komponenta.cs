using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class Komponenta
    {
        protected IPosrednik posrednik;

        public Komponenta(IPosrednik posrednik = null)
        {
            this.posrednik = posrednik;
        }

        public void PostaviPosrednika(IPosrednik posrednik)
        {
            this.posrednik = posrednik;
        }
    }
}

