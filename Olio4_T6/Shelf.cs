using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T6
{
    class Shelf
    {
        private Item[] items = new Item[100];

        public Item this[int i]
        { get
            {
                return items[i];
            }
            set
            {
                items[i] = value;
            }
        }
      
}
