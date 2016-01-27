using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T6
{
    class Item : Shelf

    {
        public virtual float DiscSize
        {
            get
            {
                return 0;
            }
        }
        public void ItemInfo()
        {
            if (GetType().Name == "Disc")


                Console.WriteLine("This item is a " + GetType().Name + " with a size of ");
            else
                Console.WriteLine("This item is a " + GetType().Name);
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
