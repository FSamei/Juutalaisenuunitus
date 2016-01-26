using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esimitemit
{
    class Car
    {
        public Car(string model, int cc)
        {
            this.model = model;
            this.cc = cc;
        }
        public int EngineSize
        {
            get { return cc; }
        }
        public string ModelProperty
        {
            get { return model; }
            set
            { if (value == "corolla" || value == "avensis")
                {
                    model = value;
                }
                else
                {
                    model = "unknown";
                }
            }
        }

        // Class priave members - DO NOT TOUCH!
        private string model;
           private readonly int cc;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("corolla", 1000);
            Car toyota2 = new Car("avensis", 500);
            Car toyota3 = new Car("asd", 500);
            //toyota.ModelProperty = "saatana";
            Console.WriteLine("This toyota model is: " + toyota.ModelProperty);
            Console.WriteLine("This toyota engine size is: " + toyota.EngineSize);
            Console.ReadLine();
        
        
       
        }
    }
}
