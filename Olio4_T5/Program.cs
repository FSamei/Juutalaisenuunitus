using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio("off", 3, 9001.0f);
            radio.Status();
            radio.OnState = "on";
            radio.Volume = 9;
            radio.Taajuus += 2000.0f;

            radio.Status();
            radio.Volume = 9000;
        }
    }
}
