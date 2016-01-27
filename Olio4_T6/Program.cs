using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> shelf = new List<Item>();
            shelf.Add(new Magazine());
            shelf.Add(new Disc("DVD", 7.4f));
            shelf.Add(new Disc("Blu-ray", 50.4f));
            shelf.Add(new Disc("CD", 0.7f));

            foreach (Item item in shelf)
            {
                item.ItemInfo();
            }

            }
        }
    }

