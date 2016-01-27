using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T6
{
    class Disc : Item
    {
        private string discType;
        private float discSize;

        public Disc(string discType, float discSize)
        {
            this.discType = discType;
            if (discSize >= 0f)
                this.discSize = discSize;
            else
                this.discSize = 0f;
        }
        public override string ToString()
        {
            return "" + discSize;
        }
    }
}
