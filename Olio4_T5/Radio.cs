using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio4_T5
{
    class Radio
    {
        private string onState = "off";
        private int volume;
        private float taajuus;

        public Radio(string onState, int volume, float taajuus)
        {
            this.onState = onState;
            this.volume = volume;
            this.taajuus = taajuus;
        }

        public string OnState
        {
            get { return onState; }
            set
            {
                if (value == "on" || value == "off")
                { onState = value; }
                else { Console.WriteLine("Virtakyktkin"); }
            }
        }
        public int Volume
        {
            get { return volume; }
            set
            {
                if (value >= 0 && value <= 9)
                {
                    volume = value;

                }
                else
                {
                    volume = 0;
                }
            }
        }
        public float Taajuus
        { get { return taajuus; }
        set
            { if (value >= 2000.0f && value <= 26000.0f)
                { taajuus = value; }
                else
                {
                    Console.WriteLine("Sopimaton taajuus!");
                }
                

            }
        }
        public void Status()
        {
            Console.WriteLine("Radio on " + onState + ". Voimakkuus on " + volume + ". Taajuus on " + taajuus);
        }
    }
}
